using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("USERDATA")]
public partial class Userdatum
{
    [Key]
    [Column("strUserId")]
    [StringLength(21)]
    [Unicode(false)]
    public string StrUserId { get; set; } = null!;

    public byte Nation { get; set; }

    public byte Race { get; set; }

    public short Class { get; set; }

    public byte HairColor { get; set; }

    public byte Rank { get; set; }

    public byte Title { get; set; }

    public byte Level { get; set; }

    public int Exp { get; set; }

    public int Loyalty { get; set; }

    public byte Face { get; set; }

    public byte City { get; set; }

    public short Knights { get; set; }

    public byte Fame { get; set; }

    public short Hp { get; set; }

    public short Mp { get; set; }

    public short Sp { get; set; }

    public byte Strong { get; set; }

    public byte Sta { get; set; }

    public byte Dex { get; set; }

    public byte Intel { get; set; }

    public byte Cha { get; set; }

    public byte Authority { get; set; }

    public byte Points { get; set; }

    public int Gold { get; set; }

    public byte Zone { get; set; }

    public short? Bind { get; set; }

    [Column("PX")]
    public int Px { get; set; }

    [Column("PZ")]
    public int Pz { get; set; }

    [Column("PY")]
    public int Py { get; set; }

    [Column("dwTime")]
    public int DwTime { get; set; }

    [Column("strSkill")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StrSkill { get; set; }

    [Column("strItem")]
    [StringLength(400)]
    [Unicode(false)]
    public string? StrItem { get; set; }

    [Column("strSerial")]
    [StringLength(400)]
    [Unicode(false)]
    public string? StrSerial { get; set; }

    [Column("sQuestCount")]
    public short SQuestCount { get; set; }

    [Column("strQuest")]
    [StringLength(400)]
    [Unicode(false)]
    public string? StrQuest { get; set; }

    public int MannerPoint { get; set; }

    public int LoyaltyMonthly { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime CreateTime { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? UpdateTime { get; set; }
}
