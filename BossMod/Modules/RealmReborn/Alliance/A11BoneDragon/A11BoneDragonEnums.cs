namespace BossMod.RealmReborn.Alliance.A11BoneDragon;
public enum OID : uint
{
    Boss = 0x92B, // R5.000, x?
    BoneDragonHelper = 0x92C, // R0.500, x?
    Platinal = 0x92D, // R1.000, x?
    RottingEye = 0x982, // R1.800, x?
    Actor1e8882 = 0x1E8882, // R0.500, x?, EventObj type
    Actor1e8881 = 0x1E8881, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack = 1461, // Boss/Platinal->player, no cast, single-target
    DarkWave = 736, // Boss->self, no cast, range 6+R circle
    DarkThorn = 745, // Boss->location, no cast, range 6 circle
    MiasmaBreath = 735, // Boss->self, no cast, range 8+R ?-degree cone
    HellSlash = 341, // Platinal->player, no cast, single-target
}

public enum SID : uint
{
    Disease = 181, // Boss->player, extra=0x28

}