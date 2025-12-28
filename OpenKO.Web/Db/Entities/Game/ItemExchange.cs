using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("ITEM_EXCHANGE")]
public partial class ItemExchange
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("nNpcNum")]
    public short NNpcNum { get; set; }

    [Column("strNpcName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrNpcName { get; set; } = null!;

    [Column("strNote")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrNote { get; set; } = null!;

    [Column("bRandomFlag")]
    public byte BRandomFlag { get; set; }

    [Column("nOriginItemNum1")]
    public int NOriginItemNum1 { get; set; }

    [Column("nOriginItemCount1")]
    public short NOriginItemCount1 { get; set; }

    [Column("nOriginItemNum2")]
    public int NOriginItemNum2 { get; set; }

    [Column("nOriginItemCount2")]
    public short NOriginItemCount2 { get; set; }

    [Column("nOriginItemNum3")]
    public int NOriginItemNum3 { get; set; }

    [Column("nOriginItemCount3")]
    public short NOriginItemCount3 { get; set; }

    [Column("nOriginItemNum4")]
    public int NOriginItemNum4 { get; set; }

    [Column("nOriginItemCount4")]
    public short NOriginItemCount4 { get; set; }

    [Column("nOriginItemNum5")]
    public int NOriginItemNum5 { get; set; }

    [Column("nOriginItemCount5")]
    public short NOriginItemCount5 { get; set; }

    [Column("nExchangeItemNum1")]
    public int NExchangeItemNum1 { get; set; }

    [Column("nExchangeItemCount1")]
    public short NExchangeItemCount1 { get; set; }

    [Column("nExchangeItemNum2")]
    public int NExchangeItemNum2 { get; set; }

    [Column("nExchangeItemCount2")]
    public short NExchangeItemCount2 { get; set; }

    [Column("nExchangeItemNum3")]
    public int NExchangeItemNum3 { get; set; }

    [Column("nExchangeItemCount3")]
    public short NExchangeItemCount3 { get; set; }

    [Column("nExchangeItemNum4")]
    public int NExchangeItemNum4 { get; set; }

    [Column("nExchangeItemCount4")]
    public short NExchangeItemCount4 { get; set; }

    [Column("nExchangeItemNum5")]
    public int NExchangeItemNum5 { get; set; }

    [Column("nExchangeItemCount5")]
    public short NExchangeItemCount5 { get; set; }
}
