using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OpenKO.Web.Db.Entities.Game;

[Table("BATTLE")]
public partial class Battle
{
    [Key]
    [Column("sIndex")]
    public short SIndex { get; set; }

    [Column("byNation")]
    public byte ByNation { get; set; }

    [Column("strUserName")]
    [StringLength(21)]
    [Unicode(false)]
    public string? StrUserName { get; set; }

    [Column("byElmoArea")]
    public byte ByElmoArea { get; set; }

    [Column("byKarusArea")]
    public byte ByKarusArea { get; set; }

    [Column("byElmoAdvantage")]
    public byte ByElmoAdvantage { get; set; }

    [Column("byKarusAdvantage")]
    public byte ByKarusAdvantage { get; set; }

    [Column("byArea_1")]
    public byte ByArea1 { get; set; }

    [Column("byArea_2")]
    public byte ByArea2 { get; set; }

    [Column("byArea_3")]
    public byte ByArea3 { get; set; }

    [Column("byArea_4")]
    public byte ByArea4 { get; set; }

    [Column("byArea_5")]
    public byte ByArea5 { get; set; }

    [Column("byArea_6")]
    public byte ByArea6 { get; set; }

    [Column("byArea_7")]
    public byte ByArea7 { get; set; }

    [Column("byArea_8")]
    public byte ByArea8 { get; set; }

    [Column("byArea_9")]
    public byte ByArea9 { get; set; }

    [Column("byArea_10")]
    public byte ByArea10 { get; set; }

    [Column("byArea_11")]
    public byte ByArea11 { get; set; }
}
