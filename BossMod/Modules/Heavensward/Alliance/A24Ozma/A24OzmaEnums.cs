namespace BossMod.Heavensward.Alliance.A24Ozma;

public enum OID : uint
{
    Boss = 0x1560, // R12.500, x?
    OzmaHelper = 0x1B2, // R0.500, x?, mixed types
    SingularityFragment = 0x164D, // R3.000, x?
    Ozmasphere = 0x164B, // R1.000, x?
    SingularityEcho = 0x164E, // R4.000, x?
    Ozmashade = 0x164A, // R12.500, x?
    SingularityRipple = 0x1650, // R2.100, x?
    Actor1ea038 = 0x1EA038, // R2.000, x?, EventObj type
    Actor1ea03d = 0x1EA03D, // R2.000, x?, EventObj type
    Actor1ea036 = 0x1EA036, // R2.000, x?, EventObj type
    Actor1ea03b = 0x1EA03B, // R2.000, x?, EventObj type
    Actor1ea034 = 0x1EA034, // R2.000, x?, EventObj type
    Actor1ea039 = 0x1EA039, // R2.000, x?, EventObj type
    Actor1ea035 = 0x1EA035, // R2.000, x?, EventObj type
    Actor1ea037 = 0x1EA037, // R2.000, x?, EventObj type
    Actor1ea03a = 0x1EA03A, // R2.000, x?, EventObj type
    Actor1ea03c = 0x1EA03C, // R2.000, x?, EventObj type
    Actor1ea03e = 0x1EA03E, // R0.500, x?, EventObj type
    Actor1e848f = 0x1E848F, // R2.000, x?, EventObj type
    Actor1e8f2f = 0x1E8F2F, // R0.500, x?, EventObj type
    Actor1e8eba = 0x1E8EBA, // R2.000, x?, EventObj type
    Actor1ea042 = 0x1EA042, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1ea136 = 0x1EA136, // R2.000, x?, EventObj type
    Actor1ea033 = 0x1EA033, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    Attack1 = 6192, // OzmaHelper->player, no cast, single-target
    MeteorImpact = 6453, // SingularityFragment->self, 4.0s cast, range 20 circle
    AutoAttack = 872, // SingularityFragment->player, no cast, single-target
    Transfiguration1 = 6147, // Boss->self, no cast, single-target
    FlareStar1 = 6149, // Boss->self, no cast, range 22+R circle
    FlareStar2 = 6150, // OzmaHelper->self, no cast, range 34+R circle
    Attack2 = 6193, // OzmaHelper->self, no cast, range 40+R width 4 rect
    Explosion = 6151, // Ozmasphere->self, no cast, range 6 circle
    Transfiguration2 = 6148, // Boss->self, no cast, single-target
    BlackHole = 6144, // Boss->self, 5.0s cast, range 40 circle
    Execration1 = 6184, // Boss->self, no cast, single-target
    Execration2 = 6185, // OzmaHelper->self, no cast, range 40+R width 10 rect
    Attack3 = 6194, // OzmaHelper->players, no cast, range 4 circle
    AccelerationBomb = 6191, // Boss->self, no cast, ???
    Transfiguration3 = 6183, // Boss->self, no cast, single-target
    DebrisBurst = 6454, // SingularityFragment->self, no cast, range 40 circle
    Holy = 6190, // Boss->self, 4.0s cast, range 50 circle
}

public enum SID : uint
{
    TheHeatOfBattle = 365, // none->player, extra=0xA
    ReducedRates = 364, // none->player, extra=0x1E
    Invincibility = 1570, // none->player, extra=0x0
    Cube = 1070, // Boss->Boss, extra=0x0
    VulnerabilityUp = 202, // OzmaHelper->player, extra=0x1
    Hover = 412, // none->OzmaHelper, extra=0x0
    MeatAndMead = 360, // none->player, extra=0xA
    ProperCare = 362, // none->player, extra=0x14
    Sanction = 245, // none->player, extra=0x0
    Poison = 18, // OzmaHelper->player, extra=0x0
    Slow = 9, // OzmaHelper->player, extra=0x0
    Minimum = 438, // OzmaHelper->player, extra=0xF
    Bleeding = 1074, // OzmaHelper->player, extra=0x1/0x2/0x3
    Weakness = 43, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
    AccelerationBomb = 1072, // Boss->player, extra=0x0
    BrinkOfDeath = 44, // none->player, extra=0x0
    DamageDown = 696, // SingularityFragment->player, extra=0x0
    Pyramid = 1071, // Boss->Boss, extra=0x0
    TheRoadTo80 = 1411, // none->player, extra=0x0
    MagicVulnerabilityUp = 60, // OzmaHelper->player, extra=0x0
    Transfiguration = 6182, // Boss->self, no cast, single-target
    Meteor = 6189, // OzmaHelper->location, no cast, range 10 circle

}

public enum IconID : uint
{
    Icon_57 = 57, // player
    Icon_62 = 62, // player
    Icon_75 = 75, // player
}

public enum TetherID : uint
{
}