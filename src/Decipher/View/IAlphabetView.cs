using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.src.View
{
    internal interface IAlphabetView
    {
        event EventHandler btnPlayClicked;

        void PopulateAlphabets(Dictionary<int, string> alphabets);

        List<int> GetSelectedAlphabets();
        void ShowMessage(string message);
    }
}
