using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decipher.src.Models;
using Decipher.src.View;

namespace Decipher.View
{
    public partial class StatsView : UserControl, IStatsView
    {
        public StatsView()
        {
            InitializeComponent();

            StyleGrid(gridBestScores);
            StyleGrid(gridWeakestLetters);
        }

        public void PopulateBestScores(List<BestScores> bestScores)
        {
            gridBestScores.DataSource = bestScores;

            if (gridBestScores.Columns["Alphabet"] != null)
            {
                gridBestScores.Columns["Alphabet"].HeaderText = "Alphabet";
                gridBestScores.Columns["Alphabet"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (gridBestScores.Columns["Score"] != null)
            {
                gridBestScores.Columns["Score"].HeaderText = "Best Score";
                gridBestScores.Columns["Score"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public void PopulateWeakestLetters(List<WeakestLetter> weakestLetters)
        {
            gridWeakestLetters.DataSource = weakestLetters;

            if (gridWeakestLetters.Columns["Id"] != null)
            {
                gridWeakestLetters.Columns["Id"].Visible = false;
            }

            if (gridWeakestLetters.Columns["Glyph"] != null)
            {
                gridWeakestLetters.Columns["Glyph"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                gridWeakestLetters.Columns["Glyph"].DefaultCellStyle.Font = new Font("Times New Roman", 14f, FontStyle.Regular);
            }

            if (gridWeakestLetters.Columns["LetterName"] != null)
            {
                gridWeakestLetters.Columns["LetterName"].HeaderText = "Letter Name";
            }

            if (gridWeakestLetters.Columns["ErrorCount"] != null)
            {
                gridWeakestLetters.Columns["ErrorCount"].HeaderText = "Errors";
            }
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Color.FromArgb(45, 45, 48);
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            grid.DefaultCellStyle.ForeColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(88, 204, 2);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            grid.RowHeadersVisible = false;

            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;
        }

        private void labBestScores_Click(object sender, EventArgs e)
        {

        }
    }
}
