using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE9")]
public partial class MagicType9
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

    public byte ValidGroup { get; set; }

    public byte NationChange { get; set; }

    public short MonsterNum { get; set; }

    public byte TargetChange { get; set; }

    public byte StateChange { get; set; }

    public short Radius { get; set; }

    public short Hitrate { get; set; }

    public short Duration { get; set; }

    public short AddDamage { get; set; }

    public short Vision { get; set; }

    public int NeedItem { get; set; }
}
