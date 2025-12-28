using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("PROGRAMLIST_LOG")]
public partial class ProgramlistLog
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("strCharID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrCharId { get; set; } = null!;

    [Column("strHackToolName")]
    [StringLength(1024)]
    [Unicode(false)]
    public string StrHackToolName { get; set; } = null!;

    [Column("tWriteTime", TypeName = "smalldatetime")]
    public DateTime WriteTime { get; set; }
}
