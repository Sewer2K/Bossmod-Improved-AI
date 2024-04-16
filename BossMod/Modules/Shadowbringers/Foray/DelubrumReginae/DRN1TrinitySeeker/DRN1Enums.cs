namespace BossMod.Shadowbringers.Foray.DelubrumReginae.DRN1TrinitySeeker;

public enum OID : uint
{
    Boss = 0x3131, // R4.000, x1
    Helper = 0x233C, // R0.500
}

public enum AID : uint
{
    AutoAttack_Attack = 6497, // 3131->player, no cast, single-target
    Spell_ArchonsStoneIV = 22500, // 30B7->3131, 2.3s cast, single-target
    Weaponskill_VerdantTempest = 23222, // 3131->self, 5.0s cast, range 50 circle
    Spell_MagickedMark = 22501, // 30B7->3131, 2.5s cast, single-target
    Weaponskill_FirstMercy = 23389, // 3131->self, 3.0s cast, single-target
    Weaponskill_SecondMercy = 23390, // 3131->self, 3.0s cast, single-target
    Weaponskill_ThirdMercy = 23391, // 3131->self, 3.0s cast, single-target
    Weaponskill_FourthMercy = 23392, // 3131->self, 3.0s cast, single-target
    Weaponskill_MercyFourfold1 = 23195, // 3131->self, 2.0s cast, single-target
    Weaponskill_MercyFourfold2 = 23348, // 233C->self, 1.7s cast, range 50 180-degree cone
    Weaponskill_MercyFourfold3 = 23199, // 3131->self, no cast, single-target
    Weaponskill_MercyFourfold4 = 23196, // 3131->self, no cast, single-target
    Weaponskill_MercyFourfold5 = 23197, // 3131->self, no cast, single-target
    Weaponskill_MercyFourfold6 = 23198, // 3131->self, no cast, single-target
    Ability_VerdantPath = 23192, // 3131->self, 3.0s cast, single-target
    Weaponskill_BalefulSwathe1 = 23220, // 233C->self, 3.0s cast, range 50 180-degree cone
    Weaponskill_BalefulSwathe2 = 23219, // 3131->self, 3.0s cast, single-target
    Unknown_Ability1 = 23194, // 3131->location, no cast, single-target
    BalefulBlade = 23336, // 233C->self, no cast, ??? // Telegraph
    Weaponskill_BalefulBlade1 = 23201, // 3131->self, 8.0s cast, range 30 circle
    Weaponskill_PhantomEdge = 23200, // 3131->self, 4.0s cast, single-target
    Weaponskill_BalefulBlade2 = 23202, // 3131->self, 8.0s cast, range 30 circle
    Weaponskill_BalefulBlade3 = 23337, // 233C->self, no cast, ??? // Telegraph
    Ability_VerdantPath2 = 23193, // 3131->self, 3.0s cast, single-target
    Unknown_Ability2 = 14588, // 233C->player, no cast, single-target
    Weaponskill_IronImpact1 = 23259, // 3131->self, 5.0s cast, single-target
    Weaponskill_IronImpact2 = 23221, // 3131->self, no cast, range 50 width 8 rect
    AutoAttack_Attack2 = 6499, // 3131->player, no cast, single-target
    Weaponskill_IronSplitter1 = 23203, // 3131->self, 5.0s cast, single-target
    Weaponskill_IronSplitter2 = 23205, // 233C->self, no cast, range ?-12 donut
    Weaponskill_IronSplitter3 = 23204, // 233C->self, no cast, range 4 circle
    Weaponskill_IronSplitter4 = 23206, // 233C->self, no cast, range ?-20 donut
    Weaponskill_IronSplitter5 = 23208, // 233C->self, no cast, range ?-16 donut
    Weaponskill_IronSplitter6 = 23207, // 233C->self, no cast, range ?-8 donut
    Weaponskill_IronSplitter7 = 23209, // 233C->self, no cast, range ?-25 donut
    Weaponskill_ScorchingShackle = 23214, // 233C->self, no cast, ???
    Weaponskill_DeadIron1 = 23215, // 3131->self, 4.0s cast, single-target
    Weaponskill_DeadIron2 = 23216, // 233C->self, no cast, range 50 ?-degree cone
    Weaponskill_DeadIron3 = 23364, // 3131->self, no cast, single-target
    Ability_VerdantPath3 = 23191, // 3131->self, 3.0s cast, single-target
    Weaponskill_ActOfMercy = 23218, // 3131->self, 3.0s cast, range 50 width 8 cross
}

public enum SID : uint
{

}

public enum TetherID : uint
{

}

public enum IconID : uint
{

}
