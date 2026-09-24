using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decipher.src.View;

namespace Decipher.View
{
    public partial class MenuView : UserControl, IMenuView
    {
        public event EventHandler? btnLanguageClicked;
        public event EventHandler? btnLetterClicked;
        public MenuView()
        {
            InitializeComponent();

            btnLanguage.Click += (sender, e) => btnLanguageClicked?.Invoke(this, EventArgs.Empty);
            btnLetter.Click += (sender, e) => btnLetterClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
