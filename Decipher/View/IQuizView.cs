using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.View
{
    internal interface IQuizView
    {
        event EventHandler<string> btnAnswerClicked;

        void SetGlyph(string glyph);
        void PopulateAnswers(List<string> answers);

        void HighlightAnswers(string correctAnswer, string selectedAnswer);
        void UpdateScore(int score);
        void UpdateLives(int lives);

    }
}
