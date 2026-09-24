using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.src.View
{
    internal interface IMenuView
    {
        event EventHandler btnLanguageClicked;
        event EventHandler btnLetterClicked;
    }
}
