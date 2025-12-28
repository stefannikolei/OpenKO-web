using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("USERDATA_SKILLSHORTCUT")]
public partial class UserdataSkillshortcut
{
    [Key]
    [Column("strCharID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrCharId { get; set; } = null!;

    [Column("nCount")]
    public short NCount { get; set; }

    [Column("strSkillData")]
    [StringLength(260)]
    [Unicode(false)]
    public string StrSkillData { get; set; } = null!;
}
