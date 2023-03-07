using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab1Football.Models;

public partial class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public int ClubId { get; set; }

   // [DataType(DataType.Date)]
    //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

    public DateTime? DateOfBirth { get; set; }

    public int Price { get; set; }

    public int PositionId { get; set; }

    public int Number { get; set; }

    public int? ManagerId { get; set; }

    public virtual Club Club { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<PlayerManager> PlayerManagers { get; } = new List<PlayerManager>();

    public virtual Position Position { get; set; } = null!;
}
