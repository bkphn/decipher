using Decipher.Models;
using Decipher.View;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.Presenter
{
    internal class ScorePresenter
    {
        private readonly IScoreView _view;
        private readonly IRepository _repository;

        public event Action? PlayAgainRequested;
        public event Action? MainMenuRequested;

        public ScorePresenter(IScoreView view, IRepository repository, int userId, int currentScore, List<int> alphabetIds)
        {
            _view = view;
            _repository = repository;

            _repository.SaveGameScore(userId, currentScore, alphabetIds);

            var allAlphabets = _repository.GetAvailableAlphabets();

            var playedNames = alphabetIds
                .Where(id => allAlphabets.ContainsKey(id))
                .Select(id => allAlphabets[id])
                .OrderBy(name => name)
                .ToList();

            string combinedAlphabetName = string.Join(" + ", playedNames);

            var allScores = _repository.GetUserBestScores(userId);

            int bestScore = allScores
                .Where(score => score.Alphabet == combinedAlphabetName)
                .Select(score => score.Score)
                .DefaultIfEmpty(currentScore)
                .Max();

            _view.SetScores(currentScore, bestScore);

            _view.btnPlayAgainClicked += (s, e) => PlayAgainRequested?.Invoke();
            _view.btnMainMenuClicked += (s, e) => MainMenuRequested?.Invoke();
        }
    }
}
