using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Decipher.src.View;

namespace Decipher.View
{
    public partial class AlphabetView : UserControl, IAlphabetView
    {
        public event EventHandler? btnPlayClicked;

        public AlphabetView()
        {
            InitializeComponent();

            btnPlay.Click += (sender, e) => btnPlayClicked?.Invoke(this, EventArgs.Empty);

            btnSelect.Click += OnSelectClicked;
            btnDeselect.Click += OnDeselectClicked;
        }

        public void PopulateAlphabets(Dictionary<int, string> alphabets)
        {
            flowLanguages.Controls.Clear();

            foreach (var alphabet in alphabets)
            {
                CheckBox check = new CheckBox
                {
                    Text = alphabet.Value,
                    Tag = alphabet.Key,
                    Appearance = Appearance.Button,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(5),
                    Padding = new Padding(10, 5, 10, 5),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(64, 64, 64),
                    ForeColor = Color.White,
                    Font = new Font("Arial Rounded MT Bold", 14f, FontStyle.Regular),
                    Size = new Size(236, 104),

                    FlatAppearance = 
                    {
                        BorderSize = 0,
                        CheckedBackColor = Color.FromArgb(88, 204, 2),
                        MouseDownBackColor = Color.FromArgb(137, 226, 25),
                        MouseOverBackColor = Color.FromArgb(72, 111, 43)
                    }
                };

                check.CheckedChanged += (sender, e) =>
                {
                    check.BackColor = check.Checked ? Color.FromArgb(88, 204, 2) : Color.FromArgb(64, 64, 64);
                    check.FlatAppearance.MouseOverBackColor = check.Checked ? Color.FromArgb(137, 226, 25) : Color.FromArgb(72, 111, 43);
                };

                flowLanguages.Controls.Add(check);
            }
        }

        public List<int> GetSelectedAlphabets()
        {
            List<int> selectedIds = new List<int>();

            foreach (Control control in flowLanguages.Controls)
            {
                if (control is CheckBox check && check.Checked)
                {
                    selectedIds.Add((int)check.Tag);
                }
            }

            return selectedIds;
        }

        private void OnSelectClicked(object? sender, EventArgs e)
        {
            foreach (Control control in flowLanguages.Controls) 
            {
                if (control is CheckBox check) check.Checked = true;
            }
        }

        private void OnDeselectClicked(object? sender, EventArgs e)
        {
            foreach (Control control in flowLanguages.Controls)
            {
                if (control is CheckBox check) check.Checked = false;
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Decipher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
