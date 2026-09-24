using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decipher.src.View
{
    internal interface IMainView
    {
        event EventHandler stripMainClicked;
        event EventHandler stripStatsClicked;
        event EventHandler stripProfileClicked;

        void SetMainContent(UserControl content);
        void SetStatus(string message);
    }
}
