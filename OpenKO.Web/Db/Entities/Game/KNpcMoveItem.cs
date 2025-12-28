using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("K_NPC_MOVE_ITEM")]
public partial class KNpcMoveItem
{
    [Key]
    [Column("sCastleIndex")]
    public short SCastleIndex { get; set; }

    [Column("byChangeItem")]
    public int? ByChangeItem { get; set; }

    [Column("sChangeSid")]
    public int? SChangeSid { get; set; }

    [Column("byMoveItem")]
    public int? ByMoveItem { get; set; }

    [Column("sMoveMinX")]
    public short? SMoveMinX { get; set; }

    [Column("sMoveMinY")]
    public short? SMoveMinY { get; set; }

    [Column("sMoveMaxX")]
    public short? SMoveMaxX { get; set; }

    [Column("sMoveMaxY")]
    public short? SMoveMaxY { get; set; }
}
