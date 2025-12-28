using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("KNIGHTS_CAPE")]
public partial class KnightsCape
{
    [Key]
    [Column("sCapeIndex")]
    public short SCapeIndex { get; set; }

    [Column("strName")]
    [StringLength(30)]
    [Unicode(false)]
    public string StrName { get; set; } = null!;

    [Column("nBuyPrice")]
    public int NBuyPrice { get; set; }

    [Column("nDuration")]
    public int NDuration { get; set; }

    [Column("byGrade")]
    public byte ByGrade { get; set; }
}
