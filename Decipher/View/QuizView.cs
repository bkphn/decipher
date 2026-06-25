using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decipher.View;

namespace Decipher.View
{
    public partial class QuizView : UserControl, IQuizView
    {
        public event EventHandler<string>? btnAnswerClicked;
        private readonly Button[] _answerButtons;
        public QuizView()
        {
            InitializeComponent();

            _answerButtons = new Button[]
            {
                btnAnswer1,
                btnAnswer2,
                btnAnswer3,
                btnAnswer4
            };

            foreach (var button in _answerButtons)
            {
                button.Click += OnAnyAnswerClicked;
            }
        }
        private void OnAnyAnswerClicked(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string selectedAnswer = button.Text;
                btnAnswerClicked?.Invoke(this, selectedAnswer);
            }
        }

        public void SetGlyph(string glyph)
        {
            labLetter.Text = glyph;
        }

        public void PopulateAnswers(List<string> answers)
        {
            for (int i = 0; i < answers.Count && i < _answerButtons.Length; i++)
            {
                _answerButtons[i].Text = answers[i];
                _answerButtons[i].Visible = true;

                _answerButtons[i].BackColor = System.Drawing.Color.FromArgb(75, 75, 75);
                _answerButtons[i].UseVisualStyleBackColor = false;
            }
        }

        public void UpdateScore(int score)
        {
            labScore.Text = $"Score: {score}";
        }

        public void UpdateLives(int lives)
        {
            labLives.Text = new string('❤', lives);
            labLives.ForeColor = System.Drawing.Color.FromArgb(88, 204, 2);
        }

        public void HighlightAnswers(string correctAnswer, string selectedAnswer)
        {
            foreach (var button in _answerButtons)
            {
                if (button.Text == correctAnswer)
                {
                    button.BackColor = System.Drawing.Color.FromArgb(147, 211, 51);
                }
                else if (button.Text == selectedAnswer && selectedAnswer != correctAnswer)
                {
                    button.BackColor = System.Drawing.Color.FromArgb(238, 85, 85);
                }
            }
        }

    }
}
