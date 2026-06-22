using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decipher.Models
{
    public class WeakestLetter
    {
        public int Id { get; set; }
        public string Glyph { get; set; }
        public string LetterName { get; set; }
        public int ErrorCount { get; set; }
    }
}
