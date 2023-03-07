using System;
using System.Collections.Generic;

namespace Lab1Football.Models;

public partial class Manager
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<PlayerManager> PlayerManagers { get; } = new List<PlayerManager>();
}
