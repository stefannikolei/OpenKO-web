using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("TB_USER")]
public partial class TbUser
{
    [Key]
    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("strPasswd")]
    [StringLength(13)]
    [Unicode(false)]
    public string StrPasswd { get; set; } = null!;

    [Column("strSocNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string StrSocNo { get; set; } = null!;

    [Column("strEmail")]
    [StringLength(250)]
    [Unicode(false)]
    public string StrEmail { get; set; } = null!;

    [Column("strAuthority")]
    public byte StrAuthority { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PremiumExpire { get; set; }
}
