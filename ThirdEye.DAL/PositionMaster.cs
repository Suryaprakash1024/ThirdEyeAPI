using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ThirdEye.DAL;

[Table("PositionMaster")]
public partial class PositionMaster
{
    [Key]
    public int Id { get; set; }

    [StringLength(120)]
    [Unicode(false)]
    public string? PositionId { get; set; }

    [Column("x")]
    public int? X { get; set; }

    [Column("y")]
    public int? Y { get; set; }

    [Column("shape")]
    [StringLength(120)]
    [Unicode(false)]
    public string? Shape { get; set; }
}
