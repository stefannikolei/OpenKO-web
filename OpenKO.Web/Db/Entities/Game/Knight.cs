using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("KNIGHTS")]
[Index("Idname", Name = "IX_KNIGHTS", IsUnique = true)]
public partial class Knight
{
    [Key]
    [Column("IDNum")]
    public short Idnum { get; set; }

    public byte Flag { get; set; }

    public byte Nation { get; set; }

    public byte Ranking { get; set; }

    [Column("IDName")]
    [StringLength(21)]
    [Unicode(false)]
    public string Idname { get; set; } = null!;

    public short Members { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string Chief { get; set; } = null!;

    [Column("ViceChief_1")]
    [StringLength(21)]
    [Unicode(false)]
    public string? ViceChief1 { get; set; }

    [Column("ViceChief_2")]
    [StringLength(21)]
    [Unicode(false)]
    public string? ViceChief2 { get; set; }

    [Column("ViceChief_3")]
    [StringLength(21)]
    [Unicode(false)]
    public string? ViceChief3 { get; set; }

    [Column("strEnemyName")]
    [StringLength(21)]
    [Unicode(false)]
    public string? StrEnemyName { get; set; }

    [Column("byOldWarResult")]
    public byte ByOldWarResult { get; set; }

    [Column("nWarEnemyID")]
    public int NWarEnemyId { get; set; }

    [Column("nVictory")]
    public int NVictory { get; set; }

    [Column("nLose")]
    public int NLose { get; set; }

    public long Gold { get; set; }

    public short Domination { get; set; }

    public int Points { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime CreateTime { get; set; }

    [Column("sMarkVersion")]
    public short SMarkVersion { get; set; }

    [Column("sMarkLen")]
    public short SMarkLen { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Mark { get; set; }

    [StringLength(1600)]
    [Unicode(false)]
    public string? Stash { get; set; }

    [Column("bySiegeFlag")]
    public byte BySiegeFlag { get; set; }

    [Column("sAllianceKnights")]
    public short SAllianceKnights { get; set; }

    [Column("sCape")]
    public short SCape { get; set; }
}
