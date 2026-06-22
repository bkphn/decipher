using Decipher.Models;
using Decipher.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.Presenter
{
    internal class StatsPresenter
    {
        private readonly IStatsView _view;
        private readonly IRepository _repository;
        private readonly int _userId;

        public StatsPresenter(IStatsView view, IRepository repository, int userId)
        {
            _view = view;
            _repository = repository;
            _userId = userId;

            LoadData();
        }

        private void LoadData()
        {
            var bestScores = _repository.GetUserBestLanguages(_userId);
            var weakLetters = _repository.GetUserWeakestLetters(_userId);

            _view.PopulateBestScores(bestScores);
            _view.PopulateWeakestLetters(weakLetters);
        }
    }
}
