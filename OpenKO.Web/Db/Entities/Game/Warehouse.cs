using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("WAREHOUSE")]
public partial class Warehouse
{
    [Key]
    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("nMoney")]
    public int NMoney { get; set; }

    [Column("dwTime")]
    public int DwTime { get; set; }

    [StringLength(1600)]
    [Unicode(false)]
    public string? WarehouseData { get; set; }

    [Column("strSerial")]
    [StringLength(1600)]
    [Unicode(false)]
    public string? StrSerial { get; set; }
}
