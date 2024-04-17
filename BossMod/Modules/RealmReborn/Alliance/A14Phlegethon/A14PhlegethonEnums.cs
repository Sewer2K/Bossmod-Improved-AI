namespace BossMod.RealmReborn.Alliance.A14Phlegethon;
public enum OID : uint
{
    Boss = 0x938, // R5.000, x?
    PhlegethonHelper = 0x939, // R0.500, x?
    IronClaws = 0x93A, // R2.000, x?
    IronGiant = 0x984, // R3.000, x?
    Actor1e8f87 = 0x1E8F87, // R2.000, x?, EventObj type
    Actor1e8f6a = 0x1E8F6A, // R2.000, x?, EventObj type
    Actor1e8885 = 0x1E8885, // R2.000, x?, EventObj type
    Actor1e8f88 = 0x1E8F88, // R2.000, x?, EventObj type
    Actor1e8892 = 0x1E8892, // R2.000, x?, EventObj type
    Actor1e8f8a = 0x1E8F8A, // R0.500, x?, EventObj type
    Actor1e8f94 = 0x1E8F94, // R0.500, x?, EventObj type
    Actor1e8f91 = 0x1E8F91, // R0.500, x?, EventObj type
    Actor1e8f95 = 0x1E8F95, // R2.000, x?, EventObj type
    Actor1e8f92 = 0x1E8F92, // R0.500, x?, EventObj type
    Actor1e8f93 = 0x1E8F93, // R0.500, x?, EventObj type
    Actor1e8f90 = 0x1E8F90, // R0.500, x?, EventObj type
    Actor1e8f89 = 0x1E8F89, // R2.000, x?, EventObj type
    Actor1e8894 = 0x1E8894, // R2.000, x?, EventObj type
    Actor1e9162 = 0x1E9162, // R0.500, x?, EventObj type
    Actor1e8893 = 0x1E8893, // R0.500, x?, EventObj type
    Actor1e8f96 = 0x1E8F96, // R2.000, x?, EventObj type
    Actor1e8f69 = 0x1E8F69, // R2.000, x?, EventObj type
    Actor1e8f6b = 0x1E8F6B, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack1 = 1461, // Boss/IronGiant->player, no cast, single-target

    GreatDivide = 1725, // Boss->self, no cast, range 5+R width 8 rect

    VacuumSlash1 = 1733, // Boss->self, 3.0s cast, single-target
    VacuumSlash2 = 1736, // PhlegethonHelper->self, 3.0s cast, range 80+R ?-degree cone
    MoonfallSlash = 1780, // Boss->self, 3.0s cast, range 10+R 120-degree cone

    AbyssalSlash1 = 1734, // Boss->self, 3.0s cast, single-target
    AbyssalSlash2 = 1737, // PhlegethonHelper->self, 3.0s cast, range 7+R ?-degree cone
    AbyssalSlash3 = 1739, // PhlegethonHelper->self, 3.0s cast, range 17+R ?-degree cone
    AbyssalSlash4 = 1738, // PhlegethonHelper->self, 3.0s cast, range 12+R ?-degree cone

    MegiddoFlame1 = 1735, // Boss->self, 3.0s cast, single-target
    MegiddoFlame2 = 1741, // PhlegethonHelper->location, 3.0s cast, range 3 circle
    MegiddoFlame3 = 1742, // PhlegethonHelper->location, 3.0s cast, range 4 circle
    MegiddoFlame4 = 1743, // PhlegethonHelper->location, 3.0s cast, range 5 circle
    MegiddoFlame5 = 1744, // PhlegethonHelper->location, 3.0s cast, range 6 circle

    AncientFlare1 = 1730, // Boss->self, 7.0s cast, single-target
    AncientFlare2 = 1748, // Boss->self, no cast, ???

    Quake = 1745, // Boss->self, no cast, ???
    QuakeIII = 1732, // Boss->self, 1.0s cast, ???

    GrandSword = 1785, // IronGiant->self, no cast, range 12+R 120-degree cone
    DeathGrip = 610, // IronClaws->player, no cast, single-target
    AutoAttack2 = 1459, // IronClaws->player, no cast, single-target
}

public enum SID : uint
{
    Invincibility = 1570, // none->player, extra=0x0
    Seized = 3697, // IronClaws->player, extra=0x0
    Burns = 284, // none->player, extra=0x0

}