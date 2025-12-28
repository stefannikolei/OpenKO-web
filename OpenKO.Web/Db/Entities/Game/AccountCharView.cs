using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Keyless]
public partial class AccountCharView
{
    [Column("strAccountID")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrAccountId { get; set; } = null!;
}
