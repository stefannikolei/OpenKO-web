using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("CONCURRENT")]
public partial class Concurrent
{
    [Key]
    [Column("serverid")]
    public byte Serverid { get; set; }

    [Column("zone1_count")]
    public short Zone1Count { get; set; }

    [Column("zone2_count")]
    public short Zone2Count { get; set; }

    [Column("zone3_count")]
    public short Zone3Count { get; set; }

    [Column("bz")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Bz { get; set; }
}
