using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE7")]
public partial class MagicType7
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("strName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StrName { get; set; }

    [Column("strNote")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StrNote { get; set; }

    [Column("byValidGroup")]
    public byte ByValidGroup { get; set; }

    [Column("byNatoinChange")]
    public byte ByNatoinChange { get; set; }

    [Column("shMonsterNum")]
    public short ShMonsterNum { get; set; }

    [Column("byTargetChange")]
    public byte ByTargetChange { get; set; }

    [Column("byStateChange")]
    public byte ByStateChange { get; set; }

    [Column("byRadius")]
    public byte ByRadius { get; set; }

    [Column("shHitrate")]
    public short ShHitrate { get; set; }

    [Column("shDuration")]
    public short ShDuration { get; set; }

    [Column("shDamage")]
    public short ShDamage { get; set; }

    [Column("byVisoin")]
    public byte ByVisoin { get; set; }

    [Column("nNeedItem")]
    public int NNeedItem { get; set; }
}
