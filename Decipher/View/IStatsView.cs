using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Decipher.Models;

namespace Decipher.View
{
    internal interface IStatsView
    {
        void PopulateWeakestLetters(List<WeakestLetter> weakestLetters);
        void PopulateBestScores(List<BestScores> bestScores);
    }
}