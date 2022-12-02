using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ThirdEye.DAL;

[Table("ObjectMaster")]
public partial class ObjectMaster
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? Shape { get; set; }
}
