using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MONSTER_SUMMON_LIST")]
public partial class MonsterSummonList
{
    [Key]
    [Column("sSid")]
    public short SSid { get; set; }

    [Column("strName")]
    [StringLength(31)]
    [Unicode(false)]
    public string StrName { get; set; } = null!;

    [Column("sLevel")]
    public short SLevel { get; set; }

    [Column("sProbability")]
    public short SProbability { get; set; }

    [Column("bType")]
    public byte BType { get; set; }
}
