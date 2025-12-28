using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC_TYPE8")]
public partial class MagicType8
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

    public byte Target { get; set; }

    public short Radius { get; set; }

    public byte WarpType { get; set; }

    public short ExpRecover { get; set; }
}
