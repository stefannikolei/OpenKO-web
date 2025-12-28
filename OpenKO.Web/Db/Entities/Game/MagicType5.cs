using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE5")]
public partial class MagicType5
{
    [Key]
    [Column("iNum")]
    public int Num { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public byte Type { get; set; }

    public byte ExpRecover { get; set; }

    public short NeedStone { get; set; }
}
