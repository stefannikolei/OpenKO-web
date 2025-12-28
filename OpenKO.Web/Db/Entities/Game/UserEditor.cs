using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("USER_EDITOR")]
public partial class UserEditor
{
    [Column("strCharID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrCharId { get; set; } = null!;

    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("strOpID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrOpId { get; set; } = null!;

    [Column("strOpIP")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrOpIp { get; set; } = null!;

    [Column("strOldUserValue")]
    [StringLength(600)]
    [Unicode(false)]
    public string StrOldUserValue { get; set; } = null!;

    [Column("strNewUserValue")]
    [StringLength(600)]
    [Unicode(false)]
    public string StrNewUserValue { get; set; } = null!;

    [Column("strOldUserSkill")]
    [StringLength(10)]
    [Unicode(false)]
    public string StrOldUserSkill { get; set; } = null!;

    [Column("strNewUserSkill")]
    [StringLength(10)]
    [Unicode(false)]
    public string StrNewUserSkill { get; set; } = null!;

    [Column("strOldUserItem")]
    [StringLength(400)]
    [Unicode(false)]
    public string StrOldUserItem { get; set; } = null!;

    [Column("strNewUserItem")]
    [StringLength(400)]
    [Unicode(false)]
    public string StrNewUserItem { get; set; } = null!;

    [Column("strOldWHValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrOldWhvalue { get; set; } = null!;

    [Column("strNewWHValue")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrNewWhvalue { get; set; } = null!;

    [Column("strOldWHItem")]
    [StringLength(1600)]
    [Unicode(false)]
    public string StrOldWhitem { get; set; } = null!;

    [Column("strNewWHItem")]
    [StringLength(1600)]
    [Unicode(false)]
    public string StrNewWhitem { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime EditorTime { get; set; }
}
