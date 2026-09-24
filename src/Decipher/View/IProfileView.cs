using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.src.View
{
    internal interface IProfileView
    {
        event EventHandler ProfileSelected;
        event EventHandler btnProfileClicked;

        void PopulateProfiles(List<string> profiles);

        string GetSelectedProfile();
        string GetNewProfile();
        void ShowMessage(string message);
    }
}
