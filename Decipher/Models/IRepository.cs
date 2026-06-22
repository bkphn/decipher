using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.Models;
using Decipher.View;

namespace Decipher.Models
{
    internal interface IRepository
    {
        Dictionary<int, string> GetAvailableAlphabets();

        void CreateNewPlayer(string playerName);

        List<string> GetAllPlayerNames();
        List<Letter> GetLettersByAlphabetIds(List<int> alphabetsIds);
        List<Letter> GetAllLetters();
        int GetUserIdByNickname(string nickname);

        void SaveGameScore(int userId, int score, List<int> alphabetIds);

        void RecordUserError(int userId, int letterId); 
        
        List<BestScores> GetUserBestScores(int userId);
        List<BestScores> GetUserBestLanguages(int userId);
        List<WeakestLetter> GetUserWeakestLetters(int userId);

    }
}
