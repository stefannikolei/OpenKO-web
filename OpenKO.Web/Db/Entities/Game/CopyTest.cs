using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
[Table("COPY_TEST")]
public partial class CopyTest
{
    [Column("ITEMSERIAL")]
    public long Itemserial { get; set; }
}
