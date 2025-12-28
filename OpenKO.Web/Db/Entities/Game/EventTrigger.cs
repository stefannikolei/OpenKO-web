using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("EVENT_TRIGGER")]
public partial class EventTrigger
{
    [Key]
    [Column("nIndex")]
    public int NIndex { get; set; }

    [Column("bNpcType")]
    public byte BNpcType { get; set; }

    [Column("sNpcID")]
    public short SNpcId { get; set; }

    [Column("nTriggerNum")]
    public int NTriggerNum { get; set; }
}
