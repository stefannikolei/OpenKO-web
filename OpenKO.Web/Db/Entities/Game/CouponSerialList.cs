using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("COUPON_SERIAL_LIST")]
public partial class CouponSerialList
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("strSerialNum")]
    [StringLength(16)]
    [Unicode(false)]
    public string StrSerialNum { get; set; } = null!;

    [Column("nItemNum")]
    public int NItemNum { get; set; }

    [Column("sItemCount")]
    public short SItemCount { get; set; }
}
