using System;
using System.Collections.Generic;

namespace Decipher.Models;

public partial class Game
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Score { get; set; }

    public DateTime? PlayedTime { get; set; }

    public virtual User User { get; set; } = null!;

    public string Languages { get; set; } = null;
}
