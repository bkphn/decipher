namespace Decipher.View
{
    partial class StatsView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupStats = new GroupBox();
            gridBestScores = new DataGridView();
            labBestScores = new Label();
            lblWeakestLetters = new Label();
            gridWeakestLetters = new DataGridView();
            groupStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBestScores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridWeakestLetters).BeginInit();
            SuspendLayout();
            // 
            // groupStats
            // 
            groupStats.Controls.Add(gridBestScores);
            groupStats.Controls.Add(labBestScores);
            groupStats.Controls.Add(lblWeakestLetters);
            groupStats.Controls.Add(gridWeakestLetters);
            groupStats.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupStats.ForeColor = Color.White;
            groupStats.Location = new Point(3, 3);
            groupStats.Name = "groupStats";
            groupStats.Size = new Size(891, 598);
            groupStats.TabIndex = 0;
            groupStats.TabStop = false;
            groupStats.Text = "Player's Stats";
            // 
            // gridBestScores
            // 
            gridBestScores.AllowUserToAddRows = false;
            gridBestScores.AllowUserToDeleteRows = false;
            gridBestScores.BackgroundColor = Color.FromArgb(75, 75, 75);
            gridBestScores.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridBestScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridBestScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBestScores.Enabled = false;
            gridBestScores.Location = new Point(6, 115);
            gridBestScores.Name = "gridBestScores";
            gridBestScores.RowHeadersWidth = 62;
            gridBestScores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridBestScores.Size = new Size(346, 477);
            gridBestScores.TabIndex = 5;
            // 
            // labBestScores
            // 
            labBestScores.AutoSize = true;
            labBestScores.ForeColor = Color.FromArgb(88, 204, 2);
            labBestScores.Location = new Point(6, 75);
            labBestScores.Name = "labBestScores";
            labBestScores.Size = new Size(262, 37);
            labBestScores.TabIndex = 4;
            labBestScores.Text = "Best Alphabets:";
            labBestScores.Click += labBestScores_Click;
            // 
            // lblWeakestLetters
            // 
            lblWeakestLetters.AutoSize = true;
            lblWeakestLetters.ForeColor = Color.White;
            lblWeakestLetters.Location = new Point(427, 75);
            lblWeakestLetters.Name = "lblWeakestLetters";
            lblWeakestLetters.Size = new Size(278, 37);
            lblWeakestLetters.TabIndex = 3;
            lblWeakestLetters.Text = "Weakest Letters:";
            // 
            // gridWeakestLetters
            // 
            gridWeakestLetters.AllowUserToAddRows = false;
            gridWeakestLetters.AllowUserToDeleteRows = false;
            gridWeakestLetters.AllowUserToResizeColumns = false;
            gridWeakestLetters.AllowUserToResizeRows = false;
            gridWeakestLetters.BackgroundColor = Color.FromArgb(75, 75, 75);
            gridWeakestLetters.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridWeakestLetters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridWeakestLetters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridWeakestLetters.Enabled = false;
            gridWeakestLetters.Location = new Point(427, 115);
            gridWeakestLetters.Name = "gridWeakestLetters";
            gridWeakestLetters.ReadOnly = true;
            gridWeakestLetters.RowHeadersWidth = 62;
            gridWeakestLetters.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridWeakestLetters.Size = new Size(458, 477);
            gridWeakestLetters.TabIndex = 2;
            // 
            // StatsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(75, 75, 75);
            Controls.Add(groupStats);
            Name = "StatsView";
            Size = new Size(897, 604);
            groupStats.ResumeLayout(false);
            groupStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridBestScores).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridWeakestLetters).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupStats;
        private Label lblWeakestLetters;
        private DataGridView gridWeakestLetters;
        private Label labBestScores;
        private DataGridView gridBestScores;
    }
}
