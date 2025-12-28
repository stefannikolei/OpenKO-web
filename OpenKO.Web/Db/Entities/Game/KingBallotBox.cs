using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("KING_BALLOT_BOX")]
public partial class KingBallotBox
{
    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;

    [Column("strCharID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrCharId { get; set; } = null!;

    [Column("byNation")]
    public byte ByNation { get; set; }

    [Column("strCandidacyID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrCandidacyId { get; set; } = null!;
}
