﻿namespace BossMod.Heavensward.Alliance.A11Cetus;

public enum OID : uint
{
    Boss = 0x13F7, // R8.000, x?
    Cetus = 0x13FB, // R0.500, x?, mixed types
    Actor1401 = 0x1401, // R8.000, x?
    HybodusPup = 0x13F9, // R1.950, x?
    Hybodus = 0x13F8, // R3.300, x?
    Hydrocore = 0x13FA, // R2.400, x?
    Hydrosphere = 0xEEE, // R1.600, x?
    Actoreef = 0xEEF, // R1.000, x?
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1e9dd7 = 0x1E9DD7, // R2.000, x?, EventObj type
    Actor1e9dd9 = 0x1E9DD9, // R2.000, x?, EventObj type
    Actor1e9dd8 = 0x1E9DD8, // R2.000, x?, EventObj type
    Actor1e8f2f = 0x1E8F2F, // R0.500, x?, EventObj type
    Actor1e9e3d = 0x1E9E3D, // R0.500, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack1 = 872, // Boss->player, no cast, single-target
    Hydrocannon = 5155, // Boss->self, no cast, range 22+R width 6 rect
    ElectricSwipe = 5156, // Boss->self, 2.5s cast, range 17+R 60-degree cone
    BodySlam = 5158, // Boss->location, 4.0s cast, range 10 circle
    Immersion = 5159, // Boss->self, 3.0s cast, range 80+R circle
    Symbiosis = 5157, // Boss->self, 2.0s cast, single-target
    AutoAttack2 = 870, // Hybodus->player, no cast, single-target
    Hydrobomb = 5162, // Cetus->self, no cast, range 10 circle
    Jaws = 5165, // Hybodus->player, no cast, single-target
    ElectricWhorl = 5161, // Boss->self, 4.0s cast, range 60 circle
    FeedingCall1 = 5163, // Boss->self, no cast, ???
    FeedingCall2 = 5395, // Cetus->self, no cast, ???
    FeedingCall3 = 5164, // Cetus->self, no cast, ???
    Water = 5168, // Hydrocore->player, 1.0s cast, single-target
    Expulsion = 5160, // Boss->self, 3.0s cast, range 6+R circle
    BiteAndRun = 5166, // HybodusPup->player, 15.0s cast, width 5 rect charge
}

public enum SID : uint
{
    Paralysis = 17, // Boss->player, extra=0x0
    Dropsy1 = 272, // none->player, extra=0x0
    Hover = 412, // none->Boss/Cetus, extra=0x0
    Electrocution = 271, // Boss->player, extra=0x0
    Stun1 = 149, // none->player, extra=0x0
    Dropsy2 = 531, // none->player, extra=0x1/0x2/0x3
    Throttle = 938, // none->player, extra=0x0
    VulnerabilityDown = 406, // none->Hydrocore, extra=0x4/0x3/0x2/0x1
    Windburn = 269, // Boss->player, extra=0x0
    Stun2 = 2, // Boss->player, extra=0x0
    Invincibility = 1570, // none->player, extra=0x0
}

public enum IconID : uint
{
    Icon_20 = 20, // player
}

public enum TetherID : uint
{
    Tether_3 = 3, // Hydrosphere->Hydrocore
}
