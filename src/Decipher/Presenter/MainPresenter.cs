using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.Models;
using Decipher.src.Presenter;
using Decipher.View;

namespace Decipher.Presenter
{
    internal class MainPresenter
    {
        private readonly IMainView _view;
        private readonly IRepository _repository;
        private int _currentUserId = 0;

        public MainPresenter(IMainView view, IRepository repository)
        {
            _view = view;
            _repository = repository;

            _view.stripProfileClicked += (sender, e) => ShowProfile();
            _view.stripStatsClicked += (sender, e) => ShowStats();
            _view.stripMainClicked += (sender, e) => ShowMenu();

            ShowProfile();
        }

        private void ShowProfile()
        {
            var view = new ProfileView();
            var presenter = new ProfilePresenter(view, _repository);

            presenter.ProfileReady += (nickname) =>
            {
                _currentUserId = _repository.GetUserIdByNickname(nickname);

                _view.SetStatus($"Profile: {nickname}");

                ShowMenu();
            };

            _view.SetMainContent(view);
        }

        public void ShowMenu()
        {
            if (_currentUserId == 0)
            {
                ShowMessage("Choose your profile!");
                return;
            }

            var view = new MenuView();

            var presenter = new MenuPresenter(view);

            presenter.GameModeSelected += (mode) =>
            {
                if (mode == "Script")
                {
                    StartQuiz("Script");
                }
                else if (mode == "Letter")
                {
                    ShowAlphabetSelection();
                }
            };

            _view.SetMainContent(view);
        }

        private void ShowStats()
        {
            if (_currentUserId == 0)
            {
                ShowMessage("Choose your profile!");
                return;
            }

            var view = new StatsView();
            var presenter = new StatsPresenter(view, _repository, _currentUserId);

            _view.SetMainContent(view);
        }

        private void ShowAlphabetSelection()
        {
            var view = new AlphabetView();
            var presenter = new AlphabetPresenter(view, _repository);

            presenter.GameStartRequested += (selectedIds) => {
                StartQuiz("Letter", selectedIds);
            };

            _view.SetMainContent(view);
        }

        private void StartQuiz(string mode, List<int> selectedIds = null)
        {
            var letters = (selectedIds != null)
                ? _repository.GetLettersByAlphabetIds(selectedIds)
                : _repository.GetAllLetters();

            var alphabets = _repository.GetAvailableAlphabets();

            var view = new QuizView();
            var presenter = new QuizPresenter(view, _repository, letters, alphabets, _currentUserId, mode);

            presenter.QuizFinished += (score) => ShowScoreScreen(score, mode, selectedIds);

            _view.SetMainContent(view);
        }

        private void ShowScoreScreen(int score, string mode, List<int>? selectedIds = null)
        {
            List<int> playedAlphabetIds;

            if (mode == "Script")
            {
                playedAlphabetIds = new List<int> { -1 };
            }
            else if (selectedIds != null)
            {
                playedAlphabetIds = selectedIds;
            }
            else
            {
                playedAlphabetIds = new List<int>();
            }

            var view = new ScoreView();

            var presenter = new ScorePresenter(view, _repository, _currentUserId, score, playedAlphabetIds);

            presenter.PlayAgainRequested += () => StartQuiz(mode, selectedIds);
            presenter.MainMenuRequested += ShowMenu;

            _view.SetMainContent(view);
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Decipher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
