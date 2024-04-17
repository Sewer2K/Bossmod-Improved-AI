namespace BossMod.RealmReborn.Alliance.A23Amon;
public enum OID : uint
{
    Boss = 0xBE0, // R4.000, x?
    AmonHelper = 0x1B2, // R0.500, x?
    KumKum = 0xBE7, // R1.000-2.000, x?
    IceCage = 0xBE1, // R1.800, x?
    Kichiknebik = 0xBE6, // R1.200-2.400, x?
    DimensionalCompression = 0xBE2, // R1.000, x?
    ExperimentalByProduct66 = 0xBE4, // R1.000, x?
    ExperimentalByProduct33 = 0xBE3, // R0.500-1.000, x?
    Actor1e94d3 = 0x1E94D3, // R2.000, x?, EventObj type
    Actor1e94cd = 0x1E94CD, // R2.000, x?, EventObj type
    Actor1e94d0 = 0x1E94D0, // R2.000, x?, EventObj type
    Actor1e94c7 = 0x1E94C7, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e8e9b = 0x1E8E9B, // R0.500, x?, EventObj type
    Actor1e9612 = 0x1E9612, // R0.500, x?, EventObj type
    Actor1e9519 = 0x1E9519, // R0.500, x?, EventObj type
    Actor1e951c = 0x1E951C, // R2.000, x?, EventObj type
    Actor1e9517 = 0x1E9517, // R2.000, x?, EventObj type
    Actor1e9518 = 0x1E9518, // R2.000, x?, EventObj type
    Actor1e951b = 0x1E951B, // R2.000, x?, EventObj type
    Actor1e9516 = 0x1E9516, // R2.000, x?, EventObj type
    Actor1e951d = 0x1E951D, // R2.000, x?, EventObj type
    Actor1e951a = 0x1E951A, // R2.000, x?, EventObj type
    Actor1e950c = 0x1E950C, // R2.000, x?, EventObj type
    Actor1e9515 = 0x1E9515, // R2.000, x?, EventObj type
    Actor1e94ca = 0x1E94CA, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack1k = 872, // Boss->player, no cast, single-target
    Coloratura = 2379, // Boss->self, no cast, range 8+R ?-degree cone
    BlizzagaForte = 2382, // Boss->self, 3.0s cast, range 6+R circle
    Darkness = 1875, // KumKum->self, 1.0s cast, range 6+R ?-degree cone
    FiragaForte = 2380, // Boss->self, no cast, range 60 circle
    Mini = 2371, // DimensionalCompression->player/ExperimentalByProduct33/KumKum/Kichiknebik, no cast, single-target
    RanineComedy = 2386, // Boss->self, no cast, ???
    TheLastSong = 2374, // ExperimentalByProduct33->self, no cast, range 60 circle
    MidwinterTragedy = 2385, // Boss->self, no cast, ???
    AutoAttack2 = 870, // Kichiknebik->player, no cast, single-target
    CurtainCall = 2441, // Boss->self, 15.0s cast, ???
    TheLastBout = 2372, // ExperimentalByProduct66->self, no cast, range 60 circle
    ThundagaForte1 = 2384, // AmonHelper->location, 3.5s cast, range 6 circle
    ThundagaForte2 = 2383, // Boss->location, 3.5s cast, range 6 circle

}

public enum SID : uint
{
    Invincibility = 1570, // none->player, extra=0x0
    Heavy = 14, // Boss->player, extra=0x32
    Minimum = 438, // DimensionalCompression->player/ExperimentalByProduct33/KumKum/Kichiknebik, extra=0x32
    FireToad = 511, // Boss->player, extra=0x2
    Silence = 7, // ExperimentalByProduct33->player, extra=0x0
    DeepFreeze = 487, // Boss->player, extra=0x1
    Pacification = 6, // ExperimentalByProduct66->player, extra=0x0
    Weakness = 43, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
}

public enum IconID : uint
{
    Icon_27 = 27, // player
    Icon_3 = 3, // player
}

public enum TetherID : uint
{
    Tether_1 = 1, // DimensionalCompression->player
}