using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAKE_ITEM")]
public partial class MakeItem
{
    [Key]
    [Column("sIndex")]
    public short SIndex { get; set; }

    [Column("strItemInfo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? StrItemInfo { get; set; }

    [Column("iItemCode")]
    public int ItemCode { get; set; }

    [Column("byItemLevel")]
    public byte ByItemLevel { get; set; }
}
