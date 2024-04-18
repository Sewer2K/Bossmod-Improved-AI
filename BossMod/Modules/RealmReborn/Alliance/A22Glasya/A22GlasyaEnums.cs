namespace BossMod.RealmReborn.Alliance.A22Glasya;
public enum OID : uint
{
    Boss = 0xBD7, // R4.000, x?
    GlasyaLabolasHelper = 0x1B2, // R0.500, x?, 523 type
    ClockworkWright = 0xBD9, // R0.600, x?
    Azer = 0xBD3, // R1.560, x?
    RedDragon1 = 0xBD2, // R7.000, x?
    RedDragon2 = 0xBD1, // R7.000, x?
    Actor1e963c = 0x1E963C, // R0.500, x?, EventObj type
    Actor1e94c7 = 0x1E94C7, // R2.000, x?, EventObj type
    Actor1e8e9b = 0x1E8E9B, // R0.500, x?, EventObj type
    Actor1e9515 = 0x1E9515, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e951c = 0x1E951C, // R2.000, x?, EventObj type
    Actor1e9517 = 0x1E9517, // R2.000, x?, EventObj type
    Actor1e9518 = 0x1E9518, // R2.000, x?, EventObj type
    Actor1e951b = 0x1E951B, // R2.000, x?, EventObj type
    Actor1e9516 = 0x1E9516, // R2.000, x?, EventObj type
    Actor1e951d = 0x1E951D, // R2.000, x?, EventObj type
    Actor1e951a = 0x1E951A, // R2.000, x?, EventObj type
    Actor1e950c = 0x1E950C, // R2.000, x?, EventObj type
    Actor1e94d3 = 0x1E94D3, // R2.000, x?, EventObj type
    Actor1e94cd = 0x1E94CD, // R2.000, x?, EventObj type
    Actor1e94d0 = 0x1E94D0, // R2.000, x?, EventObj type
    Actor1e94ca = 0x1E94CA, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttackk = 872, // Boss->player, no cast, single-target
    AstralPunch = 2346, // Boss->self, no cast, range 8+R 90-degree cone
    Aura = 2348, // GlasyaLabolasHelper->location, 3.5s cast, range 8 circle
    VileUtterance = 2353, // Boss->self, 3.0s cast, range 60+R ?-degree cone
    BloodMoon = 2349, // Boss->self, no cast, range 60 circle
}

public enum SID : uint
{
    Invincibility = 1570, // none->player, extra=0x0
    Fetters = 510, // none->player, extra=0x0
    Electrocution = 288, // none->player, extra=0x0
}

public enum TetherID : uint
{
    Tether_22 = 22, // ClockworkWright->Boss
}
