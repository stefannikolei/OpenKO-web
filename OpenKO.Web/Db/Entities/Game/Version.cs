using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("VERSION")]
public partial class VersionInfo
{
    [Key]
    [Column("sVersion")]
    public short SVersion { get; set; }

    [Column("strFileName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrFileName { get; set; } = null!;

    [Column("strCompressName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrCompressName { get; set; } = null!;

    [Column("sHistoryVersion")]
    public short SHistoryVersion { get; set; }
}
