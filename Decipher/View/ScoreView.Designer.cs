namespace Decipher.View
{
    partial class ScoreView
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
            labGameOver = new Label();
            labCurrent = new Label();
            labBest = new Label();
            btnPlayAgain = new Button();
            btnMainMenu = new Button();
            SuspendLayout();
            // 
            // labGameOver
            // 
            labGameOver.AutoSize = true;
            labGameOver.Font = new Font("Arial Rounded MT Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labGameOver.ForeColor = Color.White;
            labGameOver.Location = new Point(146, 28);
            labGameOver.Name = "labGameOver";
            labGameOver.Size = new Size(605, 111);
            labGameOver.TabIndex = 0;
            labGameOver.Text = "Game Over!";
            // 
            // labCurrent
            // 
            labCurrent.AutoSize = true;
            labCurrent.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCurrent.ForeColor = Color.FromArgb(88, 204, 2);
            labCurrent.Location = new Point(196, 178);
            labCurrent.Name = "labCurrent";
            labCurrent.Size = new Size(509, 83);
            labCurrent.TabIndex = 1;
            labCurrent.Text = "Your Score: X";
            // 
            // labBest
            // 
            labBest.AutoSize = true;
            labBest.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labBest.ForeColor = Color.White;
            labBest.Location = new Point(196, 298);
            labBest.Name = "labBest";
            labBest.Size = new Size(505, 83);
            labBest.TabIndex = 2;
            labBest.Text = "Best Score: X";
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.FromArgb(88, 204, 2);
            btnPlayAgain.Cursor = Cursors.Hand;
            btnPlayAgain.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayAgain.ForeColor = Color.White;
            btnPlayAgain.Location = new Point(496, 469);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(325, 98);
            btnPlayAgain.TabIndex = 3;
            btnPlayAgain.Text = "Play Again";
            btnPlayAgain.UseVisualStyleBackColor = false;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = Color.FromArgb(75, 75, 75);
            btnMainMenu.Cursor = Cursors.Hand;
            btnMainMenu.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = Color.White;
            btnMainMenu.Location = new Point(84, 469);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(325, 98);
            btnMainMenu.TabIndex = 4;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = false;
            // 
            // ScoreView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(btnMainMenu);
            Controls.Add(btnPlayAgain);
            Controls.Add(labBest);
            Controls.Add(labCurrent);
            Controls.Add(labGameOver);
            Name = "ScoreView";
            Size = new Size(897, 604);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labGameOver;
        private Label labCurrent;
        private Label labBest;
        private Button btnPlayAgain;
        private Button btnMainMenu;
    }
}
