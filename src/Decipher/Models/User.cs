using System;
using System.Collections.Generic;

namespace Decipher.Models;

public partial class User
{
    public int Id { get; set; }

    public string Nickname { get; set; } = null!;

    public DateTime? CreatedTime { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();

    public virtual ICollection<UserError> UserErrors { get; set; } = new List<UserError>();
}
