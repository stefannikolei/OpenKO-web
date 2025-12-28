using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("HOME")]
public partial class Home
{
    [Key]
    public byte Nation { get; set; }

    public int ElmoZoneX { get; set; }

    public int ElmoZoneZ { get; set; }

    [Column("ElmoZoneLX")]
    public byte ElmoZoneLx { get; set; }

    [Column("ElmoZoneLZ")]
    public byte ElmoZoneLz { get; set; }

    public int KarusZoneX { get; set; }

    public int KarusZoneZ { get; set; }

    [Column("KarusZoneLX")]
    public byte KarusZoneLx { get; set; }

    [Column("KarusZoneLZ")]
    public byte KarusZoneLz { get; set; }

    public int FreeZoneX { get; set; }

    public int FreeZoneZ { get; set; }

    [Column("FreeZoneLX")]
    public byte FreeZoneLx { get; set; }

    [Column("FreeZoneLZ")]
    public byte FreeZoneLz { get; set; }

    public int BattleZoneX { get; set; }

    public int BattleZoneZ { get; set; }

    [Column("BattleZoneLX")]
    public byte BattleZoneLx { get; set; }

    [Column("BattleZoneLZ")]
    public byte BattleZoneLz { get; set; }

    public int BattleZone2X { get; set; }

    public int BattleZone2Z { get; set; }

    [Column("BattleZone2LX")]
    public byte BattleZone2Lx { get; set; }

    [Column("BattleZone2LZ")]
    public byte BattleZone2Lz { get; set; }
}
