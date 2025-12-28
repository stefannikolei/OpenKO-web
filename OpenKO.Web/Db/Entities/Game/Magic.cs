using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAGIC")]
public partial class Magic
{
    [Key]
    public int MagicNum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? EnName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? KrName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    public byte BeforeAction { get; set; }

    public byte TargetAction { get; set; }

    public byte SelfEffect { get; set; }

    public byte FlyingEffect { get; set; }

    public short TargetEffect { get; set; }

    public byte Moral { get; set; }

    public short SkillLevel { get; set; }

    public short Skill { get; set; }

    public short Msp { get; set; }

    [Column("HP")]
    public short Hp { get; set; }

    public byte ItemGroup { get; set; }

    public int UseItem { get; set; }

    public byte CastTime { get; set; }

    public byte ReCastTime { get; set; }

    public byte SuccessRate { get; set; }

    public byte Type1 { get; set; }

    public byte Type2 { get; set; }

    public short Range { get; set; }

    public byte Etc { get; set; }

    public int Event { get; set; }
}
