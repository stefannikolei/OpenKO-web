using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("CURRENTUSER")]
public partial class Currentuser
{
    [Column("nServerNo")]
    public int NServerNo { get; set; }

    [Column("strServerIP")]
    [StringLength(20)]
    [Unicode(false)]
    public string StrServerIp { get; set; } = null!;

    [Key]
    [Column("strAccountID")]
    [StringLength(20)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("strCharID")]
    [StringLength(20)]
    [Unicode(false)]
    public string StrCharId { get; set; } = null!;

    [Column("strClientIP")]
    [StringLength(20)]
    [Unicode(false)]
    public string StrClientIp { get; set; } = null!;
}
