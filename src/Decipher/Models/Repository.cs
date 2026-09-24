using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Decipher.Models;
using Decipher.View;

namespace Decipher.Models
{
    internal class Repository : IRepository
    {
        private readonly string _connection = "Server=localhost;Database=decipher;Uid=root;Pwd=;";

        public Dictionary<int, string> GetAvailableAlphabets()
        {
            var alphabets = new Dictionary<int, string>();

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = "SELECT Id, Name FROM alphabets WHERE Id <> -1;";
                
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);

                            alphabets.Add(id, name);
                        }
                    }
                }
            }

            return alphabets;
        }

        public void CreateNewPlayer(string nickname)
        {
            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = "INSERT INTO users (Nickname) VALUES (@name);";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", nickname);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<string> GetAllPlayerNames()
        {
            var players = new List<string>();

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();
                string query = "SELECT Nickname FROM Users;";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            players.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return players;
        }

        public List<Letter> GetLettersByAlphabetIds(List<int> alphabetsIds)
        {
            var letters = new List<Letter>();

            if (alphabetsIds == null || alphabetsIds.Count == 0)
            {
                return letters;
            }

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string[] paramNames = new string[alphabetsIds.Count];
                for (int i = 0; i < alphabetsIds.Count; i++)
                {
                    paramNames[i] = $"@id{i}";
                }
                string inClause = string.Join(", ", paramNames);

                string query = $"SELECT Id, Glyph, Name, Alphabet_Id FROM letters WHERE Alphabet_Id IN ({inClause});";

                using (var command = new MySqlCommand(query, connection))
                {
                    for (int i = 0;i < alphabetsIds.Count; i++)
                    {
                        command.Parameters.AddWithValue(paramNames[i], alphabetsIds[i]);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var letter = new Letter
                            {
                                Id = reader.GetInt32(0),
                                Glyph = reader.GetString(1),
                                Name = reader.GetString(2),
                                AlphabetId = reader.IsDBNull(3) ? null : reader.GetInt32(3)
                            };

                            letters.Add(letter);
                        }
                    }
                }
            }

            return letters;
        }

        public int GetUserIdByNickname(string nickname)
        {
            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();
                string query = "SELECT Id FROM users WHERE Nickname = @nick LIMIT 1;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nick", nickname);

                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public void SaveGameScore(int userId, int score, List<int> alphabetIds)
        {
            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string insertGameQuery = @"INSERT INTO games (user_id, score, played_time) 
                                           VALUES (@userId, @score, NOW()); 
                                           SELECT LAST_INSERT_ID();";

                        int newGameId = 0;

                        using (var command = new MySqlCommand(insertGameQuery, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@userId", userId);
                            command.Parameters.AddWithValue("@score", score);

                            newGameId = Convert.ToInt32(command.ExecuteScalar());
                        }

                        if (alphabetIds != null && alphabetIds.Count > 0)
                        {
                            string insertRelationQuery = "INSERT INTO games_alphabets (game_id, alphabet_id) VALUES (@gameId, @alphabetId);";

                            using (var command = new MySqlCommand(insertRelationQuery, connection, transaction))
                            {
                                command.Parameters.Add("@gameId", MySqlDbType.Int32);
                                command.Parameters.Add("@alphabetId", MySqlDbType.Int32);

                                foreach (int alphaId in alphabetIds)
                                {
                                    command.Parameters["@gameId"].Value = newGameId;
                                    command.Parameters["@alphabetId"].Value = alphaId;
                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void RecordUserError(int userId, int letterId)
        {
            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = @"INSERT INTO user_errors (User_Id, Letter_Id, Error_Count, Last_Error_Time) 
                         VALUES (@uId, @lId, 1, NOW()) 
                         ON DUPLICATE KEY UPDATE Error_Count = Error_Count + 1, Last_Error_Time = NOW();";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uId", userId);
                    command.Parameters.AddWithValue("@lId", letterId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<BestScores> GetUserBestLanguages(int userId)
        {
            var scores = new List<BestScores>();

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = @"SELECT alphabets.name, MAX(games.Score) as MaxScore 
                         FROM games 
                         JOIN games_alphabets ON games.id = games_alphabets.game_id
                         JOIN alphabets ON games_alphabets.alphabet_id = alphabets.id
                         WHERE User_Id = @uId AND alphabets.name NOT LIKE 'Script'
                         AND games.id IN (SELECT game_id 
                                          FROM games_alphabets as ga
                                          GROUP BY game_id 
                                          HAVING COUNT(alphabet_id) = 1)
                         GROUP BY alphabets.id, alphabets.name
                         ORDER BY MaxScore DESC
                         LIMIT 13;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            scores.Add(new BestScores
                            {
                                Alphabet = reader.GetString(0),
                                Score = reader.GetInt32(1)
                            });
                        }
                    }
                }
            }

            return scores;
        }

            public List<BestScores> GetUserBestScores(int userId)
            {
                var scores = new List<BestScores>();

                using (var connection = new MySqlConnection(_connection))
                {
                    connection.Open();

                    using (var command = new MySqlCommand("BESTSCORE", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("p_UserId", userId);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                scores.Add(new BestScores
                                {
                                    Alphabet = reader.GetString("name"),
                                    Score = reader.GetInt32("MaxScore")
                                });
                            }
                        }
                    }
                }

                return scores;
            }
        public List<WeakestLetter> GetUserWeakestLetters(int userId)
        {
            var weakLetters = new List<WeakestLetter>();

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = @"SELECT l.Id, l.Glyph, l.Name AS LetterName, ue.Error_Count 
                         FROM user_errors ue
                         JOIN letters l ON ue.Letter_Id = l.Id
                         WHERE ue.User_Id = @uId
                         ORDER BY ue.Error_Count DESC
                         LIMIT 13;";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uId", userId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            weakLetters.Add(new WeakestLetter
                            {
                                Id = reader.GetInt32(0),
                                Glyph = reader.GetString(1),
                                LetterName = reader.GetString(2),
                                ErrorCount = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }

            return weakLetters;
        }

        public List<Letter> GetAllLetters()
        {
            var letters = new List<Letter>();

            using (var connection = new MySqlConnection(_connection))
            {
                connection.Open();

                string query = "SELECT Id, Glyph, Name, Alphabet_Id FROM letters;";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var letter = new Letter
                            {
                                Id = reader.GetInt32(0),
                                Glyph = reader.GetString(1),
                                Name = reader.GetString(2),
                                AlphabetId = reader.IsDBNull(3) ? null : reader.GetInt32(3)
                            };

                            letters.Add(letter);
                        }
                    }
                }
            }

            return letters;
        }
    }
}
