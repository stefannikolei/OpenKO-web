using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenKO.Web.Db.Entities.Game;

[Table("MAKE_ITEM_GROUP")]
public partial class MakeItemGroup
{
    [Key]
    [Column("iItemGroupNum")]
    public int ItemGroupNum { get; set; }

    [Column("iItem_1")]
    public int Item1 { get; set; }

    [Column("iItem_2")]
    public int Item2 { get; set; }

    [Column("iItem_3")]
    public int Item3 { get; set; }

    [Column("iItem_4")]
    public int Item4 { get; set; }

    [Column("iItem_5")]
    public int Item5 { get; set; }

    [Column("iItem_6")]
    public int Item6 { get; set; }

    [Column("iItem_7")]
    public int Item7 { get; set; }

    [Column("iItem_8")]
    public int Item8 { get; set; }

    [Column("iItem_9")]
    public int Item9 { get; set; }

    [Column("iItem_10")]
    public int Item10 { get; set; }

    [Column("iItem_11")]
    public int Item11 { get; set; }

    [Column("iItem_12")]
    public int Item12 { get; set; }

    [Column("iItem_13")]
    public int Item13 { get; set; }

    [Column("iItem_14")]
    public int Item14 { get; set; }

    [Column("iItem_15")]
    public int Item15 { get; set; }

    [Column("iItem_16")]
    public int Item16 { get; set; }

    [Column("iItem_17")]
    public int Item17 { get; set; }

    [Column("iItem_18")]
    public int Item18 { get; set; }

    [Column("iItem_19")]
    public int Item19 { get; set; }

    [Column("iItem_20")]
    public int Item20 { get; set; }

    [Column("iItem_21")]
    public int Item21 { get; set; }

    [Column("iItem_22")]
    public int Item22 { get; set; }

    [Column("iItem_23")]
    public int Item23 { get; set; }

    [Column("iItem_24")]
    public int Item24 { get; set; }

    [Column("iItem_25")]
    public int Item25 { get; set; }

    [Column("iItem_26")]
    public int Item26 { get; set; }

    [Column("iItem_27")]
    public int Item27 { get; set; }

    [Column("iItem_28")]
    public int Item28 { get; set; }

    [Column("iItem_29")]
    public int Item29 { get; set; }

    [Column("iItem_30")]
    public int Item30 { get; set; }
}
