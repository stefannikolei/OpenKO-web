using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("LEVEL_UP")]
public partial class LevelUp
{
    [Key]
    [Column("level")]
    public byte Level { get; set; }

    public int Exp { get; set; }
}
