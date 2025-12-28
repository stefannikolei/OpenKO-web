using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("USER_RENTAL_ITEM")]
public partial class UserRentalItem
{
    [Column("strUserID")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrUserId { get; set; } = null!;

    [Column("strAccountID")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("byRentalType")]
    public byte ByRentalType { get; set; }

    [Column("byRegType")]
    public byte ByRegType { get; set; }

    [Column("nRentalIndex")]
    public int NRentalIndex { get; set; }

    [Column("nItemIndex")]
    public int NItemIndex { get; set; }

    [Column("sDurability")]
    public short SDurability { get; set; }

    [Column("nSerialNumber")]
    public long NSerialNumber { get; set; }

    [Column("nRentalMoney")]
    public int NRentalMoney { get; set; }

    [Column("sRentalTime")]
    public short SRentalTime { get; set; }

    [Column("sDuringTime")]
    public short SDuringTime { get; set; }

    [Column("timeRental", TypeName = "smalldatetime")]
    public DateTime? TimeRental { get; set; }

    [Column("timeRegister", TypeName = "smalldatetime")]
    public DateTime? TimeRegister { get; set; }
}
