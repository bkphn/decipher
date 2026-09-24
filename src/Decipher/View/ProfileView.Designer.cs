namespace Decipher.View
{
    partial class ProfileView
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
            groupChoose = new GroupBox();
            listProfile = new ListBox();
            groupCreate = new GroupBox();
            btnProfile = new Button();
            labNickname = new Label();
            txtNickname = new TextBox();
            groupChoose.SuspendLayout();
            groupCreate.SuspendLayout();
            SuspendLayout();
            // 
            // groupChoose
            // 
            groupChoose.Controls.Add(listProfile);
            groupChoose.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupChoose.ForeColor = Color.White;
            groupChoose.Location = new Point(0, 3);
            groupChoose.Name = "groupChoose";
            groupChoose.Size = new Size(897, 368);
            groupChoose.TabIndex = 1;
            groupChoose.TabStop = false;
            groupChoose.Text = "Choose your profile!";
            // 
            // listProfile
            // 
            listProfile.BackColor = Color.FromArgb(75, 75, 75);
            listProfile.BorderStyle = BorderStyle.None;
            listProfile.ForeColor = Color.FromArgb(88, 204, 2);
            listProfile.FormattingEnabled = true;
            listProfile.Location = new Point(31, 54);
            listProfile.Name = "listProfile";
            listProfile.Size = new Size(826, 259);
            listProfile.TabIndex = 0;
            // 
            // groupCreate
            // 
            groupCreate.Controls.Add(btnProfile);
            groupCreate.Controls.Add(labNickname);
            groupCreate.Controls.Add(txtNickname);
            groupCreate.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupCreate.ForeColor = Color.White;
            groupCreate.Location = new Point(0, 377);
            groupCreate.Name = "groupCreate";
            groupCreate.Size = new Size(897, 224);
            groupCreate.TabIndex = 2;
            groupCreate.TabStop = false;
            groupCreate.Text = "Create profile";
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(88, 204, 2);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(612, 128);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(236, 74);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Create profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // labNickname
            // 
            labNickname.AutoSize = true;
            labNickname.Location = new Point(31, 66);
            labNickname.Name = "labNickname";
            labNickname.Size = new Size(257, 37);
            labNickname.TabIndex = 1;
            labNickname.Text = "Your nickname:";
            // 
            // txtNickname
            // 
            txtNickname.BackColor = Color.FromArgb(75, 75, 75);
            txtNickname.ForeColor = Color.White;
            txtNickname.Location = new Point(294, 63);
            txtNickname.Name = "txtNickname";
            txtNickname.Size = new Size(554, 45);
            txtNickname.TabIndex = 0;
            // 
            // ProfileView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(groupCreate);
            Controls.Add(groupChoose);
            Name = "ProfileView";
            Size = new Size(897, 604);
            groupChoose.ResumeLayout(false);
            groupCreate.ResumeLayout(false);
            groupCreate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupChoose;
        private GroupBox groupCreate;
        private Label labNickname;
        private TextBox txtNickname;
        private Button btnProfile;
        private ListBox listProfile;
    }
}
