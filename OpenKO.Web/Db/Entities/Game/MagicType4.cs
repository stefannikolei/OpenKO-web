using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE4")]
public partial class MagicType4
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

    public byte BuffType { get; set; }

    public byte Radius { get; set; }

    public short Duration { get; set; }

    public byte AttackSpeed { get; set; }

    public byte Speed { get; set; }

    [Column("AC")]
    public short Ac { get; set; }

    [Column("ACPct")]
    public short Acpct { get; set; }

    public byte Attack { get; set; }

    public byte MagicAttack { get; set; }

    [Column("MaxHP")]
    public short MaxHp { get; set; }

    public short MaxHpPct { get; set; }

    [Column("MaxMP")]
    public short MaxMp { get; set; }

    public short MaxMpPct { get; set; }

    public byte HitRate { get; set; }

    public short AvoidRate { get; set; }

    public short Str { get; set; }

    public short Sta { get; set; }

    public short Dex { get; set; }

    public short Intel { get; set; }

    public short Cha { get; set; }

    public byte FireR { get; set; }

    public byte ColdR { get; set; }

    public byte LightningR { get; set; }

    public byte MagicR { get; set; }

    public byte DiseaseR { get; set; }

    public byte PoisonR { get; set; }

    public byte ExpPct { get; set; }
}
