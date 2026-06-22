using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.View
{
    internal interface IScoreView
    {
        event EventHandler btnPlayAgainClicked;
        event EventHandler btnMainMenuClicked;
        void SetScores(int currentScore, int bestScore);
    }
}
