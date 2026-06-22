namespace Decipher
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            stripMenu = new MenuStrip();
            stripMain = new ToolStripMenuItem();
            stripStats = new ToolStripMenuItem();
            stripProfile = new ToolStripMenuItem();
            panelMain = new Panel();
            statusStrip1 = new StatusStrip();
            statusStatus = new ToolStripStatusLabel();
            stripMenu.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // stripMenu
            // 
            stripMenu.BackColor = Color.FromArgb(75, 75, 75);
            stripMenu.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stripMenu.ImageScalingSize = new Size(24, 24);
            stripMenu.Items.AddRange(new ToolStripItem[] { stripMain, stripStats, stripProfile });
            stripMenu.Location = new Point(0, 0);
            stripMenu.Name = "stripMenu";
            stripMenu.Size = new Size(921, 45);
            stripMenu.TabIndex = 0;
            // 
            // stripMain
            // 
            stripMain.ForeColor = Color.White;
            stripMain.Name = "stripMain";
            stripMain.Size = new Size(117, 41);
            stripMain.Text = "Menu";
            // 
            // stripStats
            // 
            stripStats.ForeColor = Color.White;
            stripStats.Name = "stripStats";
            stripStats.Size = new Size(112, 41);
            stripStats.Text = "Stats";
            // 
            // stripProfile
            // 
            stripProfile.BackColor = Color.FromArgb(75, 75, 75);
            stripProfile.ForeColor = Color.White;
            stripProfile.Name = "stripProfile";
            stripProfile.Size = new Size(135, 41);
            stripProfile.Text = "Profile";
            // 
            // panelMain
            // 
            panelMain.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelMain.ForeColor = Color.FromArgb(88, 204, 2);
            panelMain.Location = new Point(12, 57);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(897, 604);
            panelMain.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(64, 64, 64);
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusStatus });
            statusStrip1.Location = new Point(0, 658);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(921, 28);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "stripStatus";
            // 
            // statusStatus
            // 
            statusStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStatus.ForeColor = Color.White;
            statusStatus.Name = "statusStatus";
            statusStatus.Size = new Size(140, 21);
            statusStatus.Text = "Choose Profile";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            ClientSize = new Size(921, 686);
            Controls.Add(statusStrip1);
            Controls.Add(panelMain);
            Controls.Add(stripMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = stripMenu;
            MaximizeBox = false;
            Name = "MainView";
            Text = "Decipher";
            stripMenu.ResumeLayout(false);
            stripMenu.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip stripMenu;
        private ToolStripMenuItem stripMain;
        private ToolStripMenuItem stripStats;
        private ToolStripMenuItem stripProfile;
        private Panel panelMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusStatus;
    }
}
