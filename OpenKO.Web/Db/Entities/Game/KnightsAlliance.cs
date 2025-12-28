using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("KNIGHTS_ALLIANCE")]
public partial class KnightsAlliance
{
    [Key]
    [Column("sMainAllianceKnights")]
    public short SMainAllianceKnights { get; set; }

    [Column("sSubAllianceKnights")]
    public short SSubAllianceKnights { get; set; }

    [Column("sMercenaryClan_1")]
    public short SMercenaryClan1 { get; set; }

    [Column("sMercenaryClan_2")]
    public short SMercenaryClan2 { get; set; }
}
