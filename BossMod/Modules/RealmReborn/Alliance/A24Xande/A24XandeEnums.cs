namespace BossMod.RealmReborn.Alliance.A24Xande;
public enum OID : uint
{
    Boss = 0xBDB, // R4.000, x?
    XandeHelper = 0x19A, // R0.500, x?, 523 type
    AetherialMine = 0xBDF, // R1.000, x?
    StonefallCircle = 0xBDD, // R1.000, x?
    StarfallCircle = 0xBDC, // R1.000, x?
    Actor1e9582 = 0x1E9582, // R0.500, x?, EventObj type
    Actor1e9547 = 0x1E9547, // R2.000, x?, EventObj type
    Actor1e9548 = 0x1E9548, // R2.000, x?, EventObj type
    Actor1e9545 = 0x1E9545, // R2.000, x?, EventObj type
    Actor1e9583 = 0x1E9583, // R0.500, x?, EventObj type
    Actor1e9514 = 0x1E9514, // R2.000, x?, EventObj type
    Actor1e8e9b = 0x1E8E9B, // R0.500, x?, EventObj type
    Actor1e9513 = 0x1E9513, // R2.000, x?, EventObj type
    Actor1e9544 = 0x1E9544, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e9546 = 0x1E9546, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack = 872, // Boss->player, no cast, single-target
    DoubleAxeHandle = 2354, // Boss->player, no cast, single-target
    KnucklePress = 2355, // Boss->self, 3.0s cast, range 6+R circle
    BurningRave1 = 2357, // XandeHelper->location, 3.5s cast, range 8 circle
    BurningRave2 = 2356, // Boss->location, 3.5s cast, range 8 circle
    AncientQuake = 2359, // Boss->self, no cast, ???
    AetherochemicalExplosion = 2366, // AetherialMine->self, no cast, range 3 circle
    AetherochemicalReaction = 2365, // AetherialMine->self, no cast, range 60+R circle
    Imperium = 2367, // XandeHelper->location, no cast, range 6 circle
    AncientQuaga = 2361, // Boss->self, 5.0s cast, ???
    AuraCannon = 2358, // Boss->self, 3.0s cast, range 60+R width 10 rect
}

public enum SID : uint
{
    Weakness = 43, // none->player, extra=0x0
    Invincibility = 1570, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
    Levitation = 12, // none->player, extra=0x0

}

public enum IconID : uint
{
    Icon_317 = 317, // player
}