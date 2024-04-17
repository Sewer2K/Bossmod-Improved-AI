namespace BossMod.RealmReborn.Alliance.A21Scylla;
public enum OID : uint
{
    Boss = 0xBC1, // R3.750, x?
    ShudderingSoul = 0xBC6, // R1.000, x?
    StaffOfEldering = 0xBC2, // R1.000, x?
    ShiveringSoul = 0xBC4, // R1.000, x?
    SmolderingSoul = 0xBC5, // R1.000, x?
    Gomory = 0xBCD, // R0.900, x?
    Acheron = 0xBCE, // R2.500, x?
    Actor1b2 = 0x1B2, // R0.500, x?, 523 type
    Actor1e950c = 0x1E950C, // R2.000, x?, EventObj type
    Actor1e94c7 = 0x1E94C7, // R2.000, x?, EventObj type
    Actor1e951c = 0x1E951C, // R2.000, x?, EventObj type
    Actor1e9517 = 0x1E9517, // R2.000, x?, EventObj type
    Actor1e9518 = 0x1E9518, // R2.000, x?, EventObj type
    Actor1e951b = 0x1E951B, // R2.000, x?, EventObj type
    Actor1e9516 = 0x1E9516, // R2.000, x?, EventObj type
    Actor1e951d = 0x1E951D, // R2.000, x?, EventObj type
    Actor1e951a = 0x1E951A, // R2.000, x?, EventObj type
    Actor1e94d3 = 0x1E94D3, // R2.000, x?, EventObj type
    Actor1e9515 = 0x1E9515, // R2.000, x?, EventObj type
    Actor1e950d = 0x1E950D, // R0.500, x?, EventObj type
    Actor1e94cd = 0x1E94CD, // R2.000, x?, EventObj type
    Actor1e94d0 = 0x1E94D0, // R2.000, x?, EventObj type
    Actor1e94ca = 0x1E94CA, // R2.000, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e8e9b = 0x1E8E9B, // R0.500, x?, EventObj type

}

public enum AID : uint
{
    AutoAttack = 872, // Boss->player, no cast, single-target
    Topple = 2321, // Boss->self, 3.0s cast, range 3+R circle
    Unholy = 2319, // Boss->location, no cast, range 81 circle
    Firewalker = 2329, // Boss->self, no cast, range 5+R ?-degree cone
    Shudder = 2324, // ShudderingSoul->self, no cast, range 81 circle
    SearingChain = 2330, // StaffOfEldering->self, 3.0s cast, range 60+R width 4 rect
    InfiniteAnguish = 2331, // StaffOfEldering->self, 3.0s cast, range 12 circle
    Shiver = 2323, // ShiveringSoul->self, no cast, ???
    Smolder = 2322, // SmolderingSoul->self, no cast, range 2+R circle
    AncientFlare = 2317, // Boss->self, 10.0s cast, range 81 circle
}

public enum SID : uint
{
    Invincibility = 1570, // none->player, extra=0x0
    Heavy = 14, // none->ShiveringSoul, extra=0x32
    DeepFreeze = 487, // ShiveringSoul->player, extra=0x1
    FireResistanceUp = 520, // none->player, extra=0x0

}

public enum IconID : uint
{
    Icon_24 = 24, // player
    Icon_26 = 26, // player
    Icon_25 = 25, // player
}

public enum TetherID : uint
{
    Tether_6 = 6, // ShudderingSoul->player
    Tether_8 = 8, // ShiveringSoul->player
    Tether_5 = 5, // SmolderingSoul->player
}
