using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("KNIGHTS_RATING")]
public partial class KnightsRating
{
    [Key]
    [Column("nRank")]
    public int NRank { get; set; }

    [Column("shIndex")]
    public short ShIndex { get; set; }

    [Column("strName")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrName { get; set; } = null!;

    [Column("nPoints")]
    public int NPoints { get; set; }
}
