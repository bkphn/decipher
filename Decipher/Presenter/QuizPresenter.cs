using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.Models;
using Decipher.View;

namespace Decipher.Presenter
{
    internal class QuizPresenter
    {
        private readonly IQuizView _view;
        private readonly IRepository _repository;
        private readonly List<Letter> _letters;
        private readonly Dictionary<int, string> _alphabets;
        private readonly int _userId;
        private readonly string _gameMode;

        private Letter _currentLetter;
        private string _correctAnswer;
        private int _score = 0;
        private int _lives = 3;
        private Random _random = new Random();

        public event Action<int>? QuizFinished;

        public QuizPresenter(IQuizView view, IRepository repository, List<Letter> letters, Dictionary<int, string> alphabets, int userId, string gameMode)
        {
            _view = view;
            _repository = repository;
            _letters = letters;
            _alphabets = alphabets;
            _userId = userId;
            _gameMode = gameMode;

            _view.btnAnswerClicked += OnAnswerClicked;

            _view.UpdateScore(_score);
            _view.UpdateLives(_lives);

            LoadNext();
        }

        private void LoadNext()
        {
            if (_lives <= 0) return;

            _currentLetter = _letters[_random.Next(_letters.Count)];
            _view.SetGlyph(_currentLetter.Glyph);

            List<string> options = new List<string>();

            if (_gameMode == "Script")
            {
                _correctAnswer = _alphabets[(int)_currentLetter.AlphabetId];
                options = _alphabets.Values.ToList();
            }
            else
            {
                _correctAnswer = _currentLetter.Name;
                options = _letters.Select(letter => letter.Name).Distinct().ToList();
            }

            var finalOptions = new List<string> { _correctAnswer };
            var wrongOptions = options.Where(o => o != _correctAnswer).OrderBy(x => _random.Next()).Take(3);
            finalOptions.AddRange(wrongOptions);

            _view.PopulateAnswers(finalOptions.OrderBy(x => _random.Next()).ToList());
        }
        private void OnAnswerClicked(object? sender, string selectedAnswer)
        {
            if (selectedAnswer == _correctAnswer)
            {
                _score += 1;
                _view.UpdateScore(_score);
            }
            else
            {
                _lives--;
                _view.UpdateLives(_lives);
                _repository.RecordUserError(_userId, _currentLetter.Id);
            }

            if (_lives > 0)
            {
                LoadNext();
            }
            else
            {
                QuizFinished?.Invoke(_score);
            }
        }
    }
}
