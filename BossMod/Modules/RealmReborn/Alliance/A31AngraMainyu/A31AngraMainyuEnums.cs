namespace BossMod.RealmReborn.Alliance.A31AngraMainyu;
public enum OID : uint
{

    Boss = 0xE00, // R3.200, x?
    AngraMainyuHelper = 0x1B2, // R0.500, x?, 523 type
    FinalHourglass = 0xE02, // R1.500, x?
    GrimReaper = 0xE01, // R2.000, x?
    AngraMainyusDaewa = 0xE4E, // R1.800, x?
    WormholeGenerator = 0x1E96F3, // R2.000, x?, EventObj type
    Actor1e9714 = 0x1E9714, // R2.000, x?, EventObj type
    Actor1e96ff = 0x1E96FF, // R2.000, x?, EventObj type
    Actor1e9713 = 0x1E9713, // R2.000, x?, EventObj type
    Actor1e9822 = 0x1E9822, // R2.000, x?, EventObj type
    Actor1e9712 = 0x1E9712, // R2.000, x?, EventObj type
    Actor1e9710 = 0x1E9710, // R2.000, x?, EventObj type
    Actor1e9726 = 0x1E9726, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e970e = 0x1E970E, // R2.000, x?, EventObj type
    Actor1e8f2f = 0x1E8F2F, // R0.500, x?, EventObj type
    Actor1e9727 = 0x1E9727, // R2.000, x?, EventObj type
    Actor1e970f = 0x1E970F, // R2.000, x?, EventObj type
    Actor1e970d = 0x1E970D, // R2.000, x?, EventObj type
    Actor1e9728 = 0x1E9728, // R2.000, x?, EventObj type
    Actor1e9711 = 0x1E9711, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack = 3508, // Boss->player, no cast, single-target
    DoubleVision = 3272, // Boss->self, 2.5s cast, range 60 circle
    IrefulGaze = 3274, // AngraMainyuHelper->self, no cast, ???
    SullenGaze = 3273, // AngraMainyuHelper->self, no cast, ???
    Stare = 3280, // Boss->self, no cast, range 60+R width 8 rect
    Level100Flare1 = 3275, // Boss->location, 4.5s cast, ???
    Level100Flare2 = 3276, // AngraMainyuHelper->player, no cast, ???
    MortalGaze1 = 3281, // Boss->self, 3.0s cast, range 60 circle
    MortalGaze2 = 3499, // AngraMainyuHelper->self, 4.5s cast, range 60 circle
    Death = 3279, // GrimReaper->self, no cast, ???
    Thunder = 968, // AngraMainyusDaewa->player, 1.0s cast, single-target
    Paralyze = 1118, // AngraMainyusDaewa->player, 4.0s cast, single-target
    Level150Death1 = 3277, // Boss->location, 4.5s cast, ???
    Level150Death2 = 3278, // AngraMainyuHelper->player, no cast, ???
    EyesOnMe = 3358, // AngraMainyusDaewa->self, 4.0s cast, range 30+R circle
}

public enum SID : uint
{
    BrandOfTheIreful = 637, // AngraMainyuHelper->player, extra=0x1/0x2
    BrandOfTheSullen = 636, // AngraMainyuHelper->player, extra=0x1
    Bind = 280, // none->player, extra=0x0
    Doom = 210, // AngraMainyuHelper->player, extra=0x0
    Stun = 149, // none->player, extra=0x0
    Weakness = 43, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
    Paralysis = 17, // AngraMainyusDaewa->player, extra=0x0
    BrinkOfDeath = 44, // none->player, extra=0x0
    Suppuration = 375, // AngraMainyuHelper->player, extra=0x1
}

public enum IconID : uint
{
    Icon_44 = 44, // player
    Icon_45 = 45, // player
}

public enum TetherID : uint
{
    Tether_5 = 5, // player->player
    Tether_1 = 1, // player->player
}
