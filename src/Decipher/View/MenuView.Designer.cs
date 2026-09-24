namespace Decipher.View
{
    partial class MenuView
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
            btnLanguage = new Button();
            btnLetter = new Button();
            SuspendLayout();
            // 
            // btnLanguage
            // 
            btnLanguage.BackColor = Color.FromArgb(88, 204, 2);
            btnLanguage.Cursor = Cursors.Hand;
            btnLanguage.FlatAppearance.MouseDownBackColor = Color.FromArgb(137, 226, 25);
            btnLanguage.Font = new Font("Arial Rounded MT Bold", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLanguage.ForeColor = Color.White;
            btnLanguage.Location = new Point(165, 72);
            btnLanguage.Name = "btnLanguage";
            btnLanguage.Size = new Size(544, 195);
            btnLanguage.TabIndex = 0;
            btnLanguage.Text = "Guess the Script";
            btnLanguage.UseVisualStyleBackColor = false;
            // 
            // btnLetter
            // 
            btnLetter.BackColor = Color.FromArgb(88, 204, 2);
            btnLetter.Cursor = Cursors.Hand;
            btnLetter.FlatAppearance.MouseDownBackColor = Color.FromArgb(137, 226, 25);
            btnLetter.Font = new Font("Arial Rounded MT Bold", 35F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLetter.ForeColor = Color.White;
            btnLetter.Location = new Point(165, 322);
            btnLetter.Name = "btnLetter";
            btnLetter.Size = new Size(544, 195);
            btnLetter.TabIndex = 1;
            btnLetter.Text = "Guess the Letter";
            btnLetter.UseVisualStyleBackColor = false;
            // 
            // MenuView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(btnLetter);
            Controls.Add(btnLanguage);
            Name = "MenuView";
            Size = new Size(897, 604);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLanguage;
        private Button btnLetter;
    }
}
