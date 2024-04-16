namespace BossMod.Heavensward.Alliance.A23Headstone;

public enum OID : uint
{
    Boss = 0x166F, // R4.500, x?
    VoidFire = 0x1671, // R0.600-0.900, x?
    Parthenope = 0x1670, // R2.000, x?
    Actor1ea04c = 0x1EA04C, // R2.000, x?, EventObj type
    Actor1ea04b = 0x1EA04B, // R2.000, x?, EventObj type
    Actor1ea04a = 0x1EA04A, // R2.000, x?, EventObj type
    Actor1ea04f = 0x1EA04F, // R2.000, x?, EventObj type
    Actor1ea153 = 0x1EA153, // R2.000, x?, EventObj type
    Actor1ea04e = 0x1EA04E, // R2.000, x?, EventObj type
    Actor1ea04d = 0x1EA04D, // R2.000, x?, EventObj type
    Actor1ea152 = 0x1EA152, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e8f2f = 0x1E8F2F, // R0.500, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack = 872, // Parthenope->player, no cast, single-target
    FieryEpigraph = 6227, // Boss->player, no cast, single-target
    Epigraph = 6226, // Boss->self, no cast, range 100+R width 8 rect
    TremblingEpigraph = 6229, // Boss->self, 1.0s cast, range 100 circle
    FlaringEpigraph = 6230, // Boss->self, 30.0s cast, range 81 circle
    BigBurst = 6233, // VoidFire->self, 30.0s cast, range 100 circle
}

public enum SID : uint
{
    BrinkOfDeath = 44, // none->player, extra=0x0
    Weakness = 43, // none->player, extra=0x0
    Invincibility = 1570, // none->player, extra=0x0
    VulnerabilityDown = 350, // none->player, extra=0x0
}


public enum IconID : uint
{
}

public enum TetherID : uint
{
}