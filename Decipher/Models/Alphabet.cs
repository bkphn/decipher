using System;
using System.Collections.Generic;

namespace Decipher.Models;

public partial class Alphabet
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Letter> Letters { get; set; } = new List<Letter>();
}
