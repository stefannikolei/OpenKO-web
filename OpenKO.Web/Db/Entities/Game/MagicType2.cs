using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE2")]
public partial class MagicType2
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

    public byte HitType { get; set; }

    public short HitRate { get; set; }

    public short AddDamage { get; set; }

    public short AddRange { get; set; }

    public byte NeedArrow { get; set; }

    public short AddDamagePlus { get; set; }
}
