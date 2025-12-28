using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAKE_ITEM_LARECODE")]
public partial class MakeItemLarecode
{
    [Key]
    [Column("byLevelGrade")]
    public byte ByLevelGrade { get; set; }

    [Column("sUpgradeItem")]
    public short SUpgradeItem { get; set; }

    [Column("sLareItem")]
    public short SLareItem { get; set; }

    [Column("sMagicItem")]
    public short SMagicItem { get; set; }

    [Column("sGereralItem")]
    public short SGereralItem { get; set; }
}
