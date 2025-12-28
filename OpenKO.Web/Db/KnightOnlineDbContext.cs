using Microsoft.EntityFrameworkCore;
using OpenKO.Web.Db.Entities.Game;

namespace OpenKO.Web.Db;

public class KnightOnlineDbContext : DbContext
{
    public KnightOnlineDbContext(DbContextOptions<KnightOnlineDbContext> options)
        : base(options) { }

    public virtual DbSet<AccountChar> AccountChars { get; set; }

    public virtual DbSet<AccountCharView> AccountCharViews { get; set; }

    public virtual DbSet<Battle> Battles { get; set; }

    public virtual DbSet<Coefficient> Coefficients { get; set; }

    public virtual DbSet<Concurrent> Concurrents { get; set; }

    public virtual DbSet<CopySerialItem> CopySerialItems { get; set; }

    public virtual DbSet<CopyTest> CopyTests { get; set; }

    public virtual DbSet<CouponSerialList> CouponSerialLists { get; set; }

    public virtual DbSet<Currentuser> Currentusers { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventTrigger> EventTriggers { get; set; }

    public virtual DbSet<FriendList> FriendLists { get; set; }

    public virtual DbSet<HacktoolUserlog> HacktoolUserlogs { get; set; }

    public virtual DbSet<HeroUser> HeroUsers { get; set; }

    public virtual DbSet<Home> Homes { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemExchange> ItemExchanges { get; set; }

    public virtual DbSet<ItemGroup> ItemGroups { get; set; }

    public virtual DbSet<ItemUpgrade> ItemUpgrades { get; set; }

    public virtual DbSet<ItemupProbability> ItemupProbabilities { get; set; }

    public virtual DbSet<KMonster> KMonsters { get; set; }

    public virtual DbSet<KMonsterItem> KMonsterItems { get; set; }

    public virtual DbSet<KNpc> KNpcs { get; set; }

    public virtual DbSet<KNpcItem> KNpcItems { get; set; }

    public virtual DbSet<KNpcMoveItem> KNpcMoveItems { get; set; }

    public virtual DbSet<KNpcpo> KNpcpos { get; set; }

    public virtual DbSet<KingBallotBox> KingBallotBoxes { get; set; }

    public virtual DbSet<KingCandidacyNoticeBoard> KingCandidacyNoticeBoards { get; set; }

    public virtual DbSet<KingElectionList> KingElectionLists { get; set; }

    public virtual DbSet<KingSystem> KingSystems { get; set; }

    public virtual DbSet<Knight> Knights { get; set; }

    public virtual DbSet<KnightsAlliance> KnightsAlliances { get; set; }

    public virtual DbSet<KnightsCape> KnightsCapes { get; set; }

    public virtual DbSet<KnightsRating> KnightsRatings { get; set; }

    public virtual DbSet<KnightsSiegeWarfare> KnightsSiegeWarfares { get; set; }

    public virtual DbSet<KnightsUser> KnightsUsers { get; set; }

    public virtual DbSet<LevelUp> LevelUps { get; set; }

    public virtual DbSet<Magic> Magics { get; set; }

    public virtual DbSet<MagicType1> MagicType1 { get; set; }

    public virtual DbSet<MagicType2> MagicType2 { get; set; }

    public virtual DbSet<MagicType3> MagicType3 { get; set; }

    public virtual DbSet<MagicType4> MagicType4 { get; set; }

    public virtual DbSet<MagicType5> MagicType5 { get; set; }

    public virtual DbSet<MagicType6> MagicType6 { get; set; }

    public virtual DbSet<MagicType7> MagicType7 { get; set; }

    public virtual DbSet<MagicType8> MagicType8 { get; set; }

    public virtual DbSet<MagicType9> MagicType9 { get; set; }

    public virtual DbSet<MakeDefensive> MakeDefensives { get; set; }

    public virtual DbSet<MakeItem> MakeItems { get; set; }

    public virtual DbSet<MakeItemGradecode> MakeItemGradecodes { get; set; }

    public virtual DbSet<MakeItemGroup> MakeItemGroups { get; set; }

    public virtual DbSet<MakeItemLarecode> MakeItemLarecodes { get; set; }

    public virtual DbSet<MakeWeapon> MakeWeapons { get; set; }

    public virtual DbSet<MonsterChallenge> MonsterChallenges { get; set; }

    public virtual DbSet<MonsterChallengeSummonList> MonsterChallengeSummonLists { get; set; }

    public virtual DbSet<MonsterItemTest> MonsterItemTests { get; set; }

    public virtual DbSet<MonsterSummonList> MonsterSummonLists { get; set; }

    public virtual DbSet<ProgramlistLog> ProgramlistLogs { get; set; }

    public virtual DbSet<RentalItem> RentalItems { get; set; }

    public virtual DbSet<RentalItemList> RentalItemLists { get; set; }

    public virtual DbSet<ServerResource> ServerResources { get; set; }

    public virtual DbSet<StartPosition> StartPositions { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<UserEditor> UserEditors { get; set; }

    public virtual DbSet<UserEditorItem> UserEditorItems { get; set; }

    public virtual DbSet<UserKnightsRank> UserKnightsRanks { get; set; }

    public virtual DbSet<UserPersonalRank> UserPersonalRanks { get; set; }

    public virtual DbSet<UserRentalItem> UserRentalItems { get; set; }

    public virtual DbSet<UserSavedMagic> UserSavedMagics { get; set; }

    public virtual DbSet<UserdataSkillshortcut> UserdataSkillshortcuts { get; set; }

    public virtual DbSet<Userdatum> Userdata { get; set; }

    public virtual DbSet<VersionInfo> Versions { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WebItemmall> WebItemmalls { get; set; }

    public virtual DbSet<WebItemmallLog> WebItemmallLogs { get; set; }

    public virtual DbSet<WebpageAddress> WebpageAddresses { get; set; }

    public virtual DbSet<ZoneInfo> ZoneInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountCharView>(entity =>
        {
            entity.ToView("ACCOUNT_CHAR_VIEW");
        });

        modelBuilder.Entity<Battle>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<Coefficient>(entity =>
        {
            entity.Property(e => e.SClass).ValueGeneratedNever();
        });

        modelBuilder.Entity<CopySerialItem>(entity =>
        {
            entity.Property(e => e.ItemNum).IsFixedLength();
            entity.Property(e => e.ItemSerial).IsFixedLength();
            entity.Property(e => e.StrUserId).IsFixedLength();
        });

        modelBuilder.Entity<CouponSerialList>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<EventTrigger>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<HacktoolUserlog>(entity =>
        {
            entity
                .Property(e => e.WriteTime)
                .HasDefaultValueSql("(getdate())", "DF_HACKTOOL_USERLOG_tWriteTime");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
            entity.Property(e => e.Class).HasDefaultValue((byte)1, "DF_ITEM_Class");
        });

        modelBuilder.Entity<ItemExchange>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItemUpgrade>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<KMonster>(entity =>
        {
            entity.Property(e => e.SSid).ValueGeneratedNever();
        });

        modelBuilder.Entity<KMonsterItem>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<KNpc>(entity =>
        {
            entity.Property(e => e.SSid).ValueGeneratedNever();
        });

        modelBuilder.Entity<KNpcItem>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<KNpcMoveItem>(entity =>
        {
            entity.Property(e => e.SCastleIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<Knight>(entity =>
        {
            entity.Property(e => e.Idnum).ValueGeneratedNever();
            entity
                .Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())", "DF_KNIGHTS_CreateTime");
            entity.Property(e => e.Flag).HasDefaultValue((byte)1, "DF_KNIGHTS_Flag");
            entity.Property(e => e.Members).HasDefaultValue((short)1, "DF_KNIGHTS_Members");
            entity.Property(e => e.SCape).HasDefaultValue((short)-1, "DF_KNIGHTS_sCape");
        });

        modelBuilder.Entity<KnightsAlliance>(entity =>
        {
            entity.Property(e => e.SMainAllianceKnights).ValueGeneratedNever();
        });

        modelBuilder.Entity<KnightsCape>(entity =>
        {
            entity.Property(e => e.SCapeIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<KnightsRating>(entity =>
        {
            entity.Property(e => e.NRank).ValueGeneratedNever();
        });

        modelBuilder.Entity<KnightsSiegeWarfare>(entity =>
        {
            entity.Property(e => e.SCastleIndex).ValueGeneratedNever();
            entity
                .Property(e => e.ByGuerrillaWarDay)
                .HasDefaultValue((byte)1, "DF_KNIGHTS_SIEGE_WARFARE_byGuerrillaWarDay");
            entity
                .Property(e => e.ByGuerrillaWarTime)
                .HasDefaultValue((byte)20, "DF_KNIGHTS_SIEGE_WARFARE_byGuerrillaWarTime");
            entity
                .Property(e => e.ByWarRequestDay)
                .HasDefaultValue((byte)3, "DF_KNIGHTS_SIEGE_WARFARE_byWarRequestDay");
            entity
                .Property(e => e.ByWarRequestTime)
                .HasDefaultValue((byte)9, "DF_KNIGHTS_SIEGE_WARFARE_byWarRequestTime");
            entity.Property(e => e.StrChallengeList).IsFixedLength();
        });

        modelBuilder.Entity<Magic>(entity =>
        {
            entity.Property(e => e.MagicNum).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType1>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType2>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType3>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType4>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType5>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType6>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType7>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType8>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MagicType9>(entity =>
        {
            entity.Property(e => e.Num).ValueGeneratedNever();
        });

        modelBuilder.Entity<MakeItem>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<MakeItemGroup>(entity =>
        {
            entity.Property(e => e.ItemGroupNum).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonsterChallenge>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonsterChallengeSummonList>(entity =>
        {
            entity.Property(e => e.SIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<MonsterSummonList>(entity =>
        {
            entity.Property(e => e.SSid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ProgramlistLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity
                .Property(e => e.WriteTime)
                .HasDefaultValueSql("(getdate())", "DF_PROGRAMLIST_LOG_tWriteTime");
        });

        modelBuilder.Entity<RentalItem>(entity =>
        {
            entity.Property(e => e.NRentalIndex).ValueGeneratedNever();
            entity
                .Property(e => e.TimeRegister)
                .HasDefaultValueSql("(getdate())", "DF_RENTAL_ITEM_timeRegister");
        });

        modelBuilder.Entity<RentalItemList>(entity =>
        {
            entity
                .Property(e => e.TimeRegister)
                .HasDefaultValueSql("(getdate())", "DF_RENTAL_ITEM_LIST_timeRegister");
        });

        modelBuilder.Entity<ServerResource>(entity =>
        {
            entity.Property(e => e.NResourceId).ValueGeneratedNever();
        });

        modelBuilder.Entity<StartPosition>(entity =>
        {
            entity.Property(e => e.ZoneId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity
                .Property(e => e.PremiumExpire)
                .HasDefaultValueSql("(getdate()+(3))", "DF_TB_USER_PremiumExpire");
            entity
                .Property(e => e.StrAuthority)
                .HasDefaultValue((byte)1, "DF_TB_USER_strAuthority");
            entity.Property(e => e.StrEmail).HasDefaultValue("", "DF_TB_USER_strEmail");
            entity.Property(e => e.StrSocNo).HasDefaultValue("", "DF_TB_USER_strSocNo");
        });

        modelBuilder.Entity<UserEditor>(entity =>
        {
            entity
                .Property(e => e.EditorTime)
                .HasDefaultValueSql("(getdate())", "DF_USER_EDITOR_EditorTime");
            entity.Property(e => e.StrNewUserItem).IsFixedLength();
            entity.Property(e => e.StrNewUserSkill).IsFixedLength();
            entity.Property(e => e.StrNewUserValue).IsFixedLength();
            entity.Property(e => e.StrNewWhitem).IsFixedLength();
            entity.Property(e => e.StrNewWhvalue).IsFixedLength();
            entity.Property(e => e.StrOldUserItem).IsFixedLength();
            entity.Property(e => e.StrOldUserSkill).IsFixedLength();
            entity.Property(e => e.StrOldUserValue).IsFixedLength();
            entity.Property(e => e.StrOldWhitem).IsFixedLength();
            entity.Property(e => e.StrOldWhvalue).IsFixedLength();
        });

        modelBuilder.Entity<UserKnightsRank>(entity =>
        {
            entity.Property(e => e.ShIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserPersonalRank>(entity =>
        {
            entity.Property(e => e.NRank).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserRentalItem>(entity =>
        {
            entity
                .Property(e => e.TimeRegister)
                .HasDefaultValueSql("(getdate())", "DF_USER_RENTAL_ITEM_timeRegister");
        });

        modelBuilder.Entity<UserdataSkillshortcut>(entity =>
        {
            entity
                .Property(e => e.StrCharId)
                .HasDefaultValue("", "DF_USERDATA_SKILLSHORTCUT_strCharID");
            entity
                .Property(e => e.StrSkillData)
                .HasDefaultValueSql("(0x00)", "DF_USERDATA_SKILLSHORTCUT_strSkillData");
        });

        modelBuilder.Entity<Userdatum>(entity =>
        {
            entity.Property(e => e.Authority).HasDefaultValue((byte)1, "DF_USERDATA_Authority");
            entity
                .Property(e => e.CreateTime)
                .HasDefaultValueSql("(getdate())", "DF_USERDATA_CreateTime");
            entity.Property(e => e.Exp).HasDefaultValue(5, "DF_USERDATA_Exp");
            entity.Property(e => e.Gold).HasDefaultValue(50000, "DF_USERDATA_Gold");
            entity.Property(e => e.Hp).HasDefaultValue((short)100, "DF_USERDATA_Hp");
            entity.Property(e => e.Level).HasDefaultValue((byte)1, "DF_USERDATA_Level");
            entity.Property(e => e.Loyalty).HasDefaultValue(500, "DF_USERDATA_Loyalty");
            entity.Property(e => e.Mp).HasDefaultValue((short)100, "DF_USERDATA_Mp");
            entity.Property(e => e.Px).HasDefaultValue(268100, "DF_USERDATA_PX");
            entity.Property(e => e.Pz).HasDefaultValue(131000, "DF_USERDATA_PZ");
            entity.Property(e => e.Race).HasDefaultValue((byte)1, "DF_USERDATA_Race");
            entity.Property(e => e.Sp).HasDefaultValue((short)100, "DF_USERDATA_Sp");
            entity.Property(e => e.StrSkill).HasDefaultValueSql("(0x00)", "DF_USERDATA_strSkill");
            entity.Property(e => e.Zone).HasDefaultValue((byte)1, "DF_USERDATA_Zone");
        });

        modelBuilder.Entity<VersionInfo>(entity =>
        {
            entity.Property(e => e.SVersion).ValueGeneratedNever();
        });

        modelBuilder.Entity<WebItemmall>(entity =>
        {
            entity
                .Property(e => e.BuyTime)
                .HasDefaultValueSql("(getdate())", "DF_WEB_ITEMMALL_BuyTime");
            entity
                .Property(e => e.ItemCount)
                .HasDefaultValue((short)1, "DF_WEB_ITEMMALL_ItemCount");
        });

        modelBuilder.Entity<WebItemmallLog>(entity =>
        {
            entity
                .Property(e => e.BuyTime)
                .HasDefaultValueSql("(getdate())", "DF_WEB_ITEMMALL_LOG_BuyTime");
        });

        modelBuilder.Entity<WebpageAddress>(entity =>
        {
            entity.Property(e => e.NIndex).ValueGeneratedNever();
        });

        modelBuilder.Entity<ZoneInfo>(entity =>
        {
            entity.Property(e => e.ZoneNo).ValueGeneratedNever();
        });
    }
}
