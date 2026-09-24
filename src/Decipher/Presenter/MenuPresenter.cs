using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decipher.Models;
using Decipher.View;

namespace Decipher.Presenter
{
    internal class MenuPresenter
    {
        private readonly IMenuView _view;
        public event Action<string>? GameModeSelected;

        public MenuPresenter(IMenuView view)
        {
            _view = view;

            _view.btnLanguageClicked += (s, e) => GameModeSelected?.Invoke("Script");
            _view.btnLetterClicked += (s, e) => GameModeSelected?.Invoke("Letter");
        }

    }
}