using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab1Football.Models;

public partial class Position
{
    public int Id { get; set; }
    [Display(Name = "Позиція:")]
    public string Name { get; set; } = null!;

    public virtual ICollection<Player> Players { get; } = new List<Player>();
}
