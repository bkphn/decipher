using System;
using System.Windows.Forms;
using Decipher.View;

namespace Decipher
{
    public partial class MainView : Form, IMainView
    {
        public event EventHandler? stripMainClicked;
        public event EventHandler? stripStatsClicked;
        public event EventHandler? stripProfileClicked;
        public MainView()
        {
            InitializeComponent();

            stripMain.Click += (sender, e) => stripMainClicked?.Invoke(this, EventArgs.Empty);
            stripStats.Click += (sender, e) => stripStatsClicked?.Invoke(this, EventArgs.Empty);
            stripProfile.Click += (sender, e) => stripProfileClicked?.Invoke(this, EventArgs.Empty);

            stripMain.MouseEnter += (sender, e) => stripMenu.Cursor = Cursors.Hand;
            stripMain.MouseLeave += (sender, e) => stripMenu.Cursor = Cursors.Default;

            stripStats.MouseEnter += (sender, e) => stripMenu.Cursor = Cursors.Hand;
            stripStats.MouseLeave += (sender, e) => stripMenu.Cursor = Cursors.Default;

            stripProfile.MouseEnter += (sender, e) => stripMenu.Cursor = Cursors.Hand;
            stripProfile.MouseLeave += (sender, e) => stripMenu.Cursor = Cursors.Default;

            stripMenu.Renderer = new ToolStripProfessionalRenderer(new MenuColor());
        }

        public class MenuColor : ProfessionalColorTable
        {
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(64, 64, 64); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(64, 64, 64); }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Transparent; }
            }
        }

        public void SetMainContent(UserControl view)
        {
            panelMain.Controls.Clear();

            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
        }

        public void SetStatus(string message)
        {
            statusStatus.Text = message;
        }
    }
}