using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("ITEM_UPGRADE")]
public partial class ItemUpgrade
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("nNPCNum")]
    public short NNpcnum { get; set; }

    [Column("strName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrName { get; set; } = null!;

    [Column("strNote")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrNote { get; set; } = null!;

    [Column("nOriginType")]
    public short NOriginType { get; set; }

    [Column("nOriginItem")]
    public short NOriginItem { get; set; }

    [Column("nReqItem1")]
    public int NReqItem1 { get; set; }

    [Column("nReqItem2")]
    public int NReqItem2 { get; set; }

    [Column("nReqItem3")]
    public int NReqItem3 { get; set; }

    [Column("nReqItem4")]
    public int NReqItem4 { get; set; }

    [Column("nReqItem5")]
    public int NReqItem5 { get; set; }

    [Column("nReqItem6")]
    public int NReqItem6 { get; set; }

    [Column("nReqItem7")]
    public int NReqItem7 { get; set; }

    [Column("nReqItem8")]
    public int NReqItem8 { get; set; }

    [Column("nReqNoah")]
    public int NReqNoah { get; set; }

    [Column("bRateType")]
    public byte BRateType { get; set; }

    [Column("nGenRate")]
    public short NGenRate { get; set; }

    [Column("nGiveItem")]
    public short NGiveItem { get; set; }
}
