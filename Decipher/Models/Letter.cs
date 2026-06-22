using System;
using System.Collections.Generic;

namespace Decipher.Models;

public partial class Letter
{
    public int Id { get; set; }

    public string Glyph { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? AlphabetId { get; set; }

    public virtual Alphabet? Alphabet { get; set; }

    public virtual ICollection<UserError> UserErrors { get; set; } = new List<UserError>();
}
