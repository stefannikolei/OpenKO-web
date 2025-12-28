using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("WEBPAGE_ADDRESS")]
public partial class WebpageAddress
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("strWebPageAddress")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrWebPageAddress { get; set; } = null!;
}
