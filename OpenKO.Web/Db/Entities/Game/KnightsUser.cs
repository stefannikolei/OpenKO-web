using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[PrimaryKey("SIdnum", "StrUserId")]
[Table("KNIGHTS_USER")]
public partial class KnightsUser
{
    [Key]
    [Column("sIDNum")]
    public short SIdnum { get; set; }

    [Key]
    [Column("strUserID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrUserId { get; set; } = null!;
}
