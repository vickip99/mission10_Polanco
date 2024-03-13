﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPMission10.Models;

public partial class Bowler
{
    [Key]
    [Required]
    public int BowlerId { get; set; }

    public string? BowlerLastName { get; set; }

    public string? BowlerFirstName { get; set; }

    public string? BowlerMiddleInit { get; set; }

    public string? BowlerAddress { get; set; }

    public string? BowlerCity { get; set; }

    public string? BowlerState { get; set; }

    public string? BowlerZip { get; set; }

    public string? BowlerPhoneNumber { get; set; }

    [ForeignKey("Team")]
    public int TeamId { get; set; }
    public Team? Team { get; set; }

    public virtual ICollection<BowlerScore> BowlerScores { get; set; } = new List<BowlerScore>();
}
