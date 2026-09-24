namespace Decipher.View
{
    partial class AlphabetView
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
            btnSelect = new Button();
            btnDeselect = new Button();
            btnPlay = new Button();
            flowLanguages = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(75, 75, 75);
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(42, 495);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(236, 74);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select All";
            btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnDeselect
            // 
            btnDeselect.BackColor = Color.FromArgb(75, 75, 75);
            btnDeselect.Cursor = Cursors.Hand;
            btnDeselect.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeselect.ForeColor = Color.White;
            btnDeselect.Location = new Point(335, 495);
            btnDeselect.Name = "btnDeselect";
            btnDeselect.Size = new Size(236, 74);
            btnDeselect.TabIndex = 1;
            btnDeselect.Text = "Deselect All";
            btnDeselect.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(88, 204, 2);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(622, 495);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(236, 74);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            // 
            // flowLanguages
            // 
            flowLanguages.AutoScroll = true;
            flowLanguages.Location = new Point(42, 36);
            flowLanguages.Name = "flowLanguages";
            flowLanguages.Padding = new Padding(10);
            flowLanguages.Size = new Size(816, 427);
            flowLanguages.TabIndex = 3;
            // 
            // AlphabetView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(flowLanguages);
            Controls.Add(btnPlay);
            Controls.Add(btnDeselect);
            Controls.Add(btnSelect);
            Name = "AlphabetView";
            Size = new Size(897, 604);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelect;
        private Button btnDeselect;
        private Button btnPlay;
        private FlowLayoutPanel flowLanguages;
    }
}
