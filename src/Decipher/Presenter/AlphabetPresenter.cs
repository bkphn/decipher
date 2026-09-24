using Decipher.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.src.Models;

namespace Decipher.Presenter
{
    internal class AlphabetPresenter
    {
        private readonly IAlphabetView _view;
        private readonly IRepository _repository;

        public event Action<List<int>>? GameStartRequested;

        public AlphabetPresenter(AlphabetView view, IRepository repository)
        {
            _view = view;
            _repository = repository;

            _view.btnPlayClicked += OnPlayClicked;

            LoadAlphabets();
        }

        private void LoadAlphabets()
        {
            Dictionary<int, string> alphabets = _repository.GetAvailableAlphabets();

            _view.PopulateAlphabets(alphabets);
        }

        private void OnPlayClicked(object? sender, EventArgs e)
        {
            List<int> selectedIds = _view.GetSelectedAlphabets();

            if (selectedIds == null || !selectedIds.Any())
            {
                _view.ShowMessage("Choose at least one alphabet from the list.");
                return;
            }

            GameStartRequested?.Invoke(selectedIds);
        }
    }
}
