namespace BossMod.Shadowbringers.Foray.DelubrumReginae.DRN1TrinitySeeker;

public enum OID : uint
{
    Helper = 0x233C, // R0.500, x16, 523 type
    Boss = 0x3131, // R4.000, x1
    AetherialOrb = 0x3132, // R2.000, x0 (spawn during fight)
}


public enum AID : uint
{
    AutoAttack1 = 6497, // Boss->player, no cast, single-target
    AutoAttack2 = 6499, // Boss->player, no cast, single-target
    Teleport = 23194, // Boss->location, no cast, single-target

    VerdantTempest = 23222, // Boss->self, 5.0s cast, range 50 circle, visual (raidwide)

    VerdantPathKatana = 23191, // Boss->self, 3.0s cast, single-target
    ActOfMercy = 23218, // Boss->self, 3.0s cast, range 50 width 8 cross
    FirstMercy = 23389, // Boss->self, 3.0s cast, single-target
    SecondMercy = 23390, // Boss->self, 3.0s cast, single-target
    ThirdMercy = 23391, // Boss->self, 3.0s cast, single-target
    FourthMercy = 23392, // Boss->self, 3.0s cast, single-target
    MercyFourfold = 23195, // Boss->self, 2.0s cast, single-target
    MercyFourfoldAOE = 23348, // Helper->self, 1.7s cast, range 50 180-degree cone
    MercyFourfold1 = 23199, // Boss->self, no cast, single-target
    MercyFourfold2 = 23196, // Boss->self, no cast, single-target
    MercyFourfold3 = 23197, // Boss->self, no cast, single-target
    MercyFourfold4 = 23198, // Boss->self, no cast, single-target
    SeasonsOfMercy = 23210, // Boss->self, 5.0s cast, single-target
    MercifulBreeze = 23211, // Helper->self, 2.5s cast, range 50 width 5 rect
    MercifulMoon = 23212, // 3132->self, 4.0s cast, range 50 circle
    MercifulBlooms = 23213, // Helper->self, 9.0s cast, range 4 circle
    MercifulArc = 23223, // Boss->player, no cast, range 12 ?-degree cone

    VerdantPathSword = 23192, // Boss->self, 3.0s cast, single-target, visual (switch to sword, side aoes)
    BalefulSwathe = 23219, // Boss->self, no cast, single-target, visual (side aoes)
    BalefulSwatheAOE = 23220, // Helper->self, no cast, range 50 180-degree cone
    PhantomEdge = 23200, // Boss->self, 4.0s cast, single-target, visual (applies status changing some effects)
    ScorchingShackle = 23214, // Helper->self, no cast, ??? (happens if chains aren't broken in time)
    BalefulBlade1 = 23201, // Boss->self, 8.0s cast, range 30 circle, visual (knockback, 'blockable' variant)
    BalefulBlade2 = 23202, // Boss->self, 8.0s cast, range 30 circle, visual (knockback, 'unblockable' variant)
    BalefulBladeAOE1 = 23336, // Helper->self, no cast, ???, LOSable knockback 30
    BalefulBladeAOE2 = 23337, // Helper->self, no cast, ???, knockback 30

    VerdantPathFist = 23193, // Boss->self, 3.0s cast, single-target, visual (switch to fists, line stack)
    IronImpact = 23259, // Boss->self, 5.0s cast, single-target
    IronRose = 23221, // Boss->self, no cast, range 50 width 8 rect
    IronSplitter = 23203, // Boss->self, 5.0s cast, single-target
    IronSplitterTile1 = 23205, // Helper->self, no cast, range ?-12 donut
    IronSplitterTile2 = 23204, // Helper->self, no cast, range 4 circle
    IronSplitterTile3 = 23206, // Helper->self, no cast, range ?-20 donut
    IronSplitterSand1 = 23208, // Helper->self, no cast, range ?-16 donut
    IronSplitterSand2 = 23207, // Helper->self, no cast, range ?-8 donut
    IronSplitterSand3 = 23209, // Helper->self, no cast, range ?-25 donut
    DeadIron = 23215, // Boss->self, 4.0s cast, single-target
    DeadIronAOE = 23216, // Helper->self, no cast, range 50 ?-degree cone
    DeadIronSecond = 23364, // Boss->self, no cast, single-target

    Unknown_Ability2 = 14588, // Helper->player, no cast, single-target

    // NPC actions
    ArchonsStoneIV = 22500, // 30B7->Boss, 2.3s cast, single-target
    MagickedMark = 22501, // 30B7->Boss, 2.5s cast, single-target
    CureII = 22503, // 30B7->player, 1.5s cast, single-target
}

public enum SID : uint
{
    Mercy = 2056, // none->Boss, extra=0xF7 (-45 deg)/0xF8 (-135 deg)/0xF9 (+45deg)/0xFA (+135 deg)

    // Below not useful for this module but included for completeness
    TwiceComeRuin = 2485, // Helper->player, extra=0x1
    Doom = 2519, // Helper->player, extra=0x0
    BalefulAir = 2490, // Boss->Boss, extra=0x195
    Weakness = 43, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
    PhantomEdge = 2488, // Boss->Boss, extra=0x0
    IronAir = 2491, // Boss->Boss, extra=0x196
    BurningChains = 769, // none->player, extra=0x0
    MercifulAir = 2489, // Boss->Boss, extra=0x194
    AreaOfInfluenceUp = 1749, // none->Helper, extra=0x10
}

public enum TetherID : uint
{
    BurningChains = 128, // player->player
    DeadIron = 138, // player->Boss
}

public enum IconID : uint
{
    BurningChains = 238, // player
    DeadIron = 237, // player
    MercifulArc = 243, // player
}