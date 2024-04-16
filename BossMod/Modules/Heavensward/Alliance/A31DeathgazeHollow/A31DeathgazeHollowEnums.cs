namespace BossMod.Heavensward.Alliance.A31DeathgazeHollow;

public enum OID : uint
{
    Boss = 0x190F, // R26.000, x1
    Helper = 0x1911, // R0.500, x9
    FierceWind = 0x1912, // R1.000, x0 (spawn during fight)
    VoidSprite = 0x1910, // R2.000, x0 (spawn during fight)
    Actor1e8536 = 0x1E8536, // R2.000, x1, EventObj type
    Actor1ea2ef = 0x1EA2EF, // R0.500, x1, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x1, EventObj type
    Actor1ea235 = 0x1EA235, // R2.000, x1, EventObj type
    Actor1ea23c = 0x1EA23C, // R2.000, x1, EventObj type
    Actor1ea240 = 0x1EA240, // R2.000, x1, EventObj type
    Actor1ea238 = 0x1EA238, // R2.000, x1, EventObj type
    Actor1ea234 = 0x1EA234, // R2.000, x1, EventObj type
    Actor1ea23b = 0x1EA23B, // R2.000, x1, EventObj type
    Actor1ea237 = 0x1EA237, // R2.000, x1, EventObj type
    Actor1ea23f = 0x1EA23F, // R2.000, x1, EventObj type
    Actor1ea243 = 0x1EA243, // R2.000, x1, EventObj type
    Actor1ea23a = 0x1EA23A, // R2.000, x1, EventObj type
    Actor1ea236 = 0x1EA236, // R2.000, x1, EventObj type
    Actor1ea23e = 0x1EA23E, // R2.000, x1, EventObj type
    Actor1ea233 = 0x1EA233, // R2.000, x1, EventObj type
    Actor1ea239 = 0x1EA239, // R2.000, x1, EventObj type
    Actor1ea23d = 0x1EA23D, // R2.000, x1, EventObj type
    Actor1ea232 = 0x1EA232, // R2.000, x1, EventObj type
    Actor1ea241 = 0x1EA241, // R2.000, x1, EventObj type
    Actor1ea2e7 = 0x1EA2E7, // R0.500, x0 (spawn during fight), EventObj type
    Actor1ea273 = 0x1EA273, // R2.000, x0 (spawn during fight), EventObj type
}


public enum AID : uint
{
    SpikeOfDarkness = 7761, // Boss->player, no cast, single-target
    Unknown1 = 7313, // Helper->self, no cast, range 40 circle
    Unknown2 = 7314, // Helper->self, no cast, range 40 circle
    Unknown3 = 7310, // Helper->self, 6.0s cast, range 40 circle
    Unknown4 = 7297, // Boss->self, no cast, single-target


    VoidDeathVisual = 7295, // Boss->self, 8.4s cast, single-target
    VoidDeath = 7312, // Helper->self, 9.0s cast, range 10 circle

    VoidAeroIIVisual = 7289, // Boss->self, 5.0s cast, single-target
    VoidAeroII = 7308, // Helper->players, no cast, range 5 circle

    BitingWind = 7317, // FierceWind->self, no cast, range 4 circle
    VoidBlizzardIII = 7285, // Boss->self, 2.5s cast, single-target
    VoidBlizzardIII2 = 7306, // Helper->self, 3.0s cast, range 40+R ?-degree cone
    VoidAeroIII = 7291, // Boss->self, 3.0s cast, single-target
    VoidAeroIII2 = 7309, // Helper->self, 6.0s cast, range 10 circle

    Doomsay = 7301, // Boss->self, 3.0s cast, range 100 circle
    Doomsay2 = 7300, // Boss->self, 3.0s cast, range 100 circle

    VoidBlizzardIV = 7287, // Boss->self, 3.0s cast, single-target
    Benediction = 6844, // Helper->location, 5.0s cast, range 6 circle
    VoidBlizzardIV2 = 7307, // Helper->location, 5.0s cast, range 40 circle
    VoidAeroIV = 7292, // Boss->self, 2.5s cast, single-target
    VoidAeroIV2 = 7311, // Helper->self, 3.0s cast, range 31+R width 60 rect
    VoidAeroII3 = 7288, // Boss->self, 5.0s cast, single-target
    VoidAeroIII3 = 7290, // Boss->self, 3.0s cast, single-target
    BoltOfDarkness = 7302, // Boss->self, 6.0s cast, single-target
    BoltOfDarkness2 = 7315, // Helper->self, 6.8s cast, range 31+R width 20 rect
    VoidDeathIV = 7298, // Boss->self, 3.0s cast, single-target
    Ruin = 2214, // VoidSprite->player, 1.0s cast, single-target
    VoidBlizzardIII3 = 7284, // Boss->self, 2.5s cast, single-target
    DarkII = 7318, // VoidSprite->self, 2.5s cast, range 50+R 60-degree cone
    VoidDeath3 = 7294, // Boss->self, 8.4s cast, single-target
    VoidBlizzardIV3 = 7286, // Boss->self, 3.0s cast, single-target
    VoidAeroIV3 = 7293, // Boss->self, 2.5s cast, single-target
}

public enum SID : uint
{
    Frostbite = 268, // Helper->player, extra=0x0
    Doom = 910, // Boss->player, extra=0x0
    Windburn = 269, // FierceWind->player, extra=0x0
    Bleeding = 273, // Helper->player, extra=0x0
    Heavy = 1107, // VoidSprite->player, extra=0x32
}


public enum IconID : uint
{
    _Gen_Icon_70 = 70, // player
}