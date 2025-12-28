using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("ITEMUP_PROBABILITY")]
public partial class ItemupProbability
{
    [Key]
    [Column("bType")]
    public byte BType { get; set; }

    [Column("nMaxSuccess")]
    public short NMaxSuccess { get; set; }

    [Column("nMaxFail")]
    public short NMaxFail { get; set; }

    [Column("nCurSuccess")]
    public short NCurSuccess { get; set; }

    [Column("nCurFail")]
    public short NCurFail { get; set; }
}
