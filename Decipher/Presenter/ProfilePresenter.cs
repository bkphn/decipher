using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.Models;
using Decipher.View;

namespace Decipher.Presenter
{
    internal class ProfilePresenter
    {
        private readonly IProfileView _view;
        private readonly IRepository _repository;

        public event Action<string>? ProfileReady;

        public ProfilePresenter(IProfileView view, IRepository repository)
        {
            _view = view;
            _repository = repository;

            _view.ProfileSelected += OnProfileSelected;
            _view.btnProfileClicked+= OnProfileCreated;

            LoadProfiles();
        }

        private void LoadProfiles()
        {
            var players = _repository.GetAllPlayerNames();
            _view.PopulateProfiles(players);
        }

        private void OnProfileSelected(object? sender, EventArgs e)
        {
            string selectedNickname = _view.GetSelectedProfile();

            if (string.IsNullOrEmpty(selectedNickname))
            {
                _view.ShowMessage("Choose your profile.");
                return;
            }

            ProfileReady?.Invoke(selectedNickname);
        }

        private void OnProfileCreated(object? sender, EventArgs e)
        {
            string newNickname = _view.GetNewProfile();

            if (string.IsNullOrWhiteSpace(newNickname))
            {
                _view.ShowMessage("Nickname can't be empty.");
                return;
            }

            var existingPlayers = _repository.GetAllPlayerNames();
            if (existingPlayers.Contains(newNickname))
            {
                _view.ShowMessage("Profile with chosen nickname already exists.");
                return;
            }

            _repository.CreateNewPlayer(newNickname);

            LoadProfiles();
            _view.ShowMessage($"New profile: '{newNickname}' created!");
        }
    }
}
