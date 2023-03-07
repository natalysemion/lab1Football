using System;
using System.Collections.Generic;

namespace Lab1Football.Models;

public partial class Club
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Place { get; set; }

    public int? HeadcoachId { get; set; }

    public string? Info { get; set; }

    public int Points { get; set; }

    public virtual Headcoach? Headcoach { get; set; }

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
