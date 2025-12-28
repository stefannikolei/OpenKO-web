using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("K_NPC_ITEM")]
public partial class KNpcItem
{
    [Key]
    [Column("sIndex")]
    public short SIndex { get; set; }

    [Column("iItem01")]
    public int Item01 { get; set; }

    [Column("sPersent01")]
    public short? SPersent01 { get; set; }

    [Column("iItem02")]
    public int? Item02 { get; set; }

    [Column("sPersent02")]
    public short? SPersent02 { get; set; }

    [Column("iItem03")]
    public int? Item03 { get; set; }

    [Column("sPersent03")]
    public short? SPersent03 { get; set; }

    [Column("iItem04")]
    public int? Item04 { get; set; }

    [Column("sPersent04")]
    public short? SPersent04 { get; set; }

    [Column("iItem05")]
    public int? Item05 { get; set; }

    [Column("sPersent05")]
    public short? SPersent05 { get; set; }
}
