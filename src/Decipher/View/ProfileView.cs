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
    public partial class ProfileView : UserControl, IProfileView
    {
        public event EventHandler? ProfileSelected;
        public event EventHandler? btnProfileClicked;
        public ProfileView()
        {
            InitializeComponent();

            listProfile.MouseMove += (sender, e) =>
            {
                int index = listProfile.IndexFromPoint(e.Location);
                listProfile.Cursor = (index != ListBox.NoMatches) ? Cursors.Hand : Cursors.Default;
            };

            listProfile.MouseLeave += (sender, e) =>
            {
                listProfile.Cursor = Cursors.Default;
            };

            txtNickname.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;

                    btnProfile.PerformClick();
                }
            };

            listProfile.SelectedIndexChanged += (sender, e) => ProfileSelected?.Invoke(this, EventArgs.Empty);
            btnProfile.Click += (sender, e) => btnProfileClicked?.Invoke(this, EventArgs.Empty);

            if (listProfile.SelectedIndex != -1)
            {
                ProfileSelected?.Invoke(this, EventArgs.Empty);
            }
        }

        public void PopulateProfiles(List<string> profiles)
        {
            listProfile.Items.Clear();

            foreach(var profile in profiles)
            {
                listProfile.Items.Add($"{profile}");
            }

            listProfile.SelectedIndex = -1;
            listProfile.Refresh();
        }

        public string GetSelectedProfile()
        {
            return listProfile.SelectedItem?.ToString() ?? string.Empty;
        }

        public string GetNewProfile()
        {
            return txtNickname.Text.Trim();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Decipher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
