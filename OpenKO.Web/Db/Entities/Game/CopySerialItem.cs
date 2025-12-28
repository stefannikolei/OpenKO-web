using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("COPY_SERIAL_ITEM")]
public partial class CopySerialItem
{
    [Column("strUserId")]
    [StringLength(21)]
    [Unicode(false)]
    public string? StrUserId { get; set; }

    [Column("byType")]
    public byte? ByType { get; set; }

    [Column("nPos")]
    public short? NPos { get; set; }

    [MaxLength(4)]
    public byte[]? ItemNum { get; set; }

    [MaxLength(8)]
    public byte[]? ItemSerial { get; set; }
}
