using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("SERVER_RESOURCE")]
public partial class ServerResource
{
    [Key]
    [Column("nResourceID")]
    public int NResourceId { get; set; }

    [Column("strName")]
    [StringLength(50)]
    [Unicode(false)]
    public string StrName { get; set; } = null!;

    [Column("strResource")]
    [StringLength(100)]
    [Unicode(false)]
    public string StrResource { get; set; } = null!;
}
