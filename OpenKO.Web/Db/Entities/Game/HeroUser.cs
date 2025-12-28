using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("HERO_USER")]
public partial class HeroUser
{
    [Column("shIndex")]
    public short ShIndex { get; set; }

    [Column("strUserID")]
    [StringLength(21)]
    [Unicode(false)]
    public string? StrUserId { get; set; }

    [Column("strNation")]
    [StringLength(20)]
    [Unicode(false)]
    public string? StrNation { get; set; }

    [Column("strClass")]
    [StringLength(30)]
    [Unicode(false)]
    public string? StrClass { get; set; }

    [Column("strAchievement")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StrAchievement { get; set; }
}
