using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("USER_EDITOR_ITEM")]
public partial class UserEditorItem
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

    [Column("sDBIndex")]
    public short SDbindex { get; set; }

    [Column("sPos")]
    public short SPos { get; set; }

    [Column("byType")]
    public byte ByType { get; set; }

    [Column("nItemID1")]
    public int NItemId1 { get; set; }

    [Column("nItemID2")]
    public int NItemId2 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdateTime { get; set; }
}
