namespace Decipher.View
{
    partial class QuizView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labLetter = new Label();
            tableAnswers = new TableLayoutPanel();
            btnAnswer4 = new Button();
            btnAnswer3 = new Button();
            btnAnswer2 = new Button();
            btnAnswer1 = new Button();
            labScore = new Label();
            labLives = new Label();
            tableAnswers.SuspendLayout();
            SuspendLayout();
            // 
            // labLetter
            // 
            labLetter.Anchor = AnchorStyles.Top;
            labLetter.Font = new Font("Times New Roman", 75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labLetter.ForeColor = Color.White;
            labLetter.Location = new Point(0, 103);
            labLetter.Name = "labLetter";
            labLetter.Size = new Size(897, 178);
            labLetter.TabIndex = 0;
            labLetter.Text = "A, a";
            labLetter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableAnswers
            // 
            tableAnswers.Anchor = AnchorStyles.None;
            tableAnswers.ColumnCount = 2;
            tableAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableAnswers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableAnswers.Controls.Add(btnAnswer4, 1, 1);
            tableAnswers.Controls.Add(btnAnswer3, 0, 1);
            tableAnswers.Controls.Add(btnAnswer2, 1, 0);
            tableAnswers.Controls.Add(btnAnswer1, 0, 0);
            tableAnswers.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableAnswers.Location = new Point(70, 350);
            tableAnswers.Name = "tableAnswers";
            tableAnswers.RowCount = 2;
            tableAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableAnswers.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableAnswers.Size = new Size(746, 213);
            tableAnswers.TabIndex = 1;
            // 
            // btnAnswer4
            // 
            btnAnswer4.BackColor = Color.FromArgb(75, 75, 75);
            btnAnswer4.Cursor = Cursors.Hand;
            btnAnswer4.Dock = DockStyle.Fill;
            btnAnswer4.FlatAppearance.BorderColor = Color.FromArgb(137, 226, 25);
            btnAnswer4.ForeColor = Color.White;
            btnAnswer4.Location = new Point(376, 109);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(367, 101);
            btnAnswer4.TabIndex = 3;
            btnAnswer4.Text = "Answer4";
            btnAnswer4.UseVisualStyleBackColor = false;
            // 
            // btnAnswer3
            // 
            btnAnswer3.BackColor = Color.FromArgb(75, 75, 75);
            btnAnswer3.Cursor = Cursors.Hand;
            btnAnswer3.Dock = DockStyle.Fill;
            btnAnswer3.FlatAppearance.BorderColor = Color.FromArgb(137, 226, 25);
            btnAnswer3.ForeColor = Color.White;
            btnAnswer3.Location = new Point(3, 109);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(367, 101);
            btnAnswer3.TabIndex = 2;
            btnAnswer3.Text = "Answer3";
            btnAnswer3.UseVisualStyleBackColor = false;
            // 
            // btnAnswer2
            // 
            btnAnswer2.BackColor = Color.FromArgb(75, 75, 75);
            btnAnswer2.Cursor = Cursors.Hand;
            btnAnswer2.Dock = DockStyle.Fill;
            btnAnswer2.FlatAppearance.BorderColor = Color.FromArgb(137, 226, 25);
            btnAnswer2.ForeColor = Color.White;
            btnAnswer2.Location = new Point(376, 3);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(367, 100);
            btnAnswer2.TabIndex = 1;
            btnAnswer2.Text = "Answer2";
            btnAnswer2.UseVisualStyleBackColor = false;
            // 
            // btnAnswer1
            // 
            btnAnswer1.BackColor = Color.FromArgb(75, 75, 75);
            btnAnswer1.Cursor = Cursors.Hand;
            btnAnswer1.Dock = DockStyle.Fill;
            btnAnswer1.FlatAppearance.BorderColor = Color.FromArgb(137, 226, 25);
            btnAnswer1.ForeColor = Color.White;
            btnAnswer1.Location = new Point(3, 3);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(367, 100);
            btnAnswer1.TabIndex = 0;
            btnAnswer1.Text = "Answer 1";
            btnAnswer1.UseVisualStyleBackColor = false;
            // 
            // labScore
            // 
            labScore.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labScore.ForeColor = Color.FromArgb(88, 204, 2);
            labScore.Location = new Point(16, 13);
            labScore.Name = "labScore";
            labScore.Size = new Size(239, 73);
            labScore.TabIndex = 2;
            labScore.Text = "Score: X";
            // 
            // labLives
            // 
            labLives.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labLives.ForeColor = Color.FromArgb(88, 204, 2);
            labLives.Location = new Point(641, 13);
            labLives.Name = "labLives";
            labLives.Size = new Size(239, 73);
            labLives.TabIndex = 3;
            labLives.Text = "❤️❤❤";
            labLives.TextAlign = ContentAlignment.TopRight;
            // 
            // QuizView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(labLives);
            Controls.Add(labScore);
            Controls.Add(tableAnswers);
            Controls.Add(labLetter);
            Name = "QuizView";
            Size = new Size(897, 604);
            tableAnswers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labLetter;
        private TableLayoutPanel tableAnswers;
        private Button btnAnswer4;
        private Button btnAnswer3;
        private Button btnAnswer2;
        private Button btnAnswer1;
        private Label labScore;
        private Label labLives;
    }
}
