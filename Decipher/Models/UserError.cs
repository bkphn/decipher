using System;
using System.Collections.Generic;

namespace Decipher.Models;

public partial class UserError
{
    public int UserId { get; set; }

    public int LetterId { get; set; }

    public int? ErrorCount { get; set; }

    public DateTime? LastErrorTime { get; set; }

    public virtual Letter Letter { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
