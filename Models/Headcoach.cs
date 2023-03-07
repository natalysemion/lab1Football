using System;
using System.Collections.Generic;

namespace Lab1Football.Models;

public partial class Headcoach
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Achievements { get; set; }

    public virtual ICollection<Club> Clubs { get; } = new List<Club>();
}
