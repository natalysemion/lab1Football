using System;
using System.Collections.Generic;

namespace Lab1Football.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? WorldRating { get; set; }

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
