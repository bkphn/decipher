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
    public partial class ScoreView : UserControl, IScoreView
    {
        public event EventHandler? btnPlayAgainClicked;
        public event EventHandler? btnMainMenuClicked;
        public ScoreView()
        {
            InitializeComponent();

            btnPlayAgain.Click += (sender, e) => btnPlayAgainClicked?.Invoke(this, EventArgs.Empty);
            btnMainMenu.Click += (sender, e) => btnMainMenuClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetScores(int currentScore, int bestScore)
        {
            labCurrent.Text = $"Your Score: {currentScore}";
            labBest.Text = $"Best Score: {bestScore}";
        }
    }
}
