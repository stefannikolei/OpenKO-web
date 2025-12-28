using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE3")]
public partial class MagicType3
{
    [Key]
    [Column("iNum")]
    public int Num { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public byte Radius { get; set; }

    public short Angle { get; set; }

    public byte DirectType { get; set; }

    public short FirstDamage { get; set; }

    public short EndDamage { get; set; }

    public short TimeDamage { get; set; }

    public byte Duration { get; set; }

    public byte Attribute { get; set; }
}
