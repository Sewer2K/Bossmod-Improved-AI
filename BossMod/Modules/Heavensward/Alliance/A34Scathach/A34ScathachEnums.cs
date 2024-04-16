namespace BossMod.Heavensward.Alliance.A34Scathach;

public enum OID : uint
{
    Boss = 0x194F, // R5.000, x?
    Connla = 0x19A, // R0.500, x?, mixed types
    Connla2 = 0x1952, // R2.700, x?
    ShadowLimb = 0x1950, // R2.000, x?
    ShadowcourtJester = 0x1953, // R0.600, x?
    ChimeraPoppet = 0x1954, // R2.250, x?
    ShadowcourtHound = 0x1955, // R4.440, x?
    Actor1ea24e = 0x1EA24E, // R0.500, x?, EventObj type
    Actor1ea2ef = 0x1EA2EF, // R0.500, x?, EventObj type
    Actor1e8fb8 = 0x1E8FB8, // R2.000, x?, EventObj type
    Actor1ea254 = 0x1EA254, // R2.000, x?, EventObj type
    Actor1ea255 = 0x1EA255, // R2.000, x?, EventObj type
}

public enum AID : uint
{
    AutoAttack = 7760, // Boss->player, no cast, single-target
    ThirtyThorns1 = 7467, // Boss->self, no cast, range 7+R width 3 rect
    ThirtyThorns2 = 7468, // Connla->self, no cast, range 12+R width 3 rect
    ThirtyThorns3 = 7469, // Connla->self, no cast, range 12+R width 3 rect
    ThirtyThorns4 = 7470, // Connla->self, 1.5s cast, range 8 circle
    Manos = 7379, // Boss->self, no cast, single-target
    Shadespin1 = 7454, // Boss->self, 4.0s cast, single-target
    Shadespin2 = 7456, // Connla->self, 1.2s cast, range 30+R 90-degree cone
    ThirtySickles = 7473, // Boss->self, no cast, range 15 circle
    Soar = 7451, // Boss->location, no cast, ???
    Unknown = 7452, // Boss->self, no cast, range 15 circle
    Shadesmite1 = 7636, // Connla->self, 1.5s cast, range 3 circle
    Shadesmite2 = 7453, // Connla->self, 1.5s cast, range 15 circle
    Shadesmite3 = 7637, // Connla->self, 1.5s cast, range 3 circle
    ShadowRelease = 7380, // Boss->self, no cast, single-target
    Unknown2 = 7376, // Connla2->self, no cast, single-target
    Pitfall = 7377, // Connla->self, 5.0s cast, range 60 circle
    AutoAttack3 = 871, // Connla2->player, no cast, single-target
    ThirtyArrows1 = 7471, // Boss->location, 3.0s cast, range 8 circle
    ThirtyArrows2 = 7472, // Connla->self, 2.5s cast, range 35+R width 8 rect
    ThirtySouls = 7474, // Boss->self, 4.0s cast, range 60 circle
    Shadespin = 7455, // Boss->self, 4.0s cast, single-target
    Nox1 = 7458, // Connla->location, 5.0s cast, range 10 circle
    Nox2 = 7457, // Connla->location, no cast, range 10 circle
    Shadethrust = 7459, // Boss->location, 3.0s cast, range 40+R width 5 rect
    Shred = 7460, // ShadowLimb->player, no cast, single-target
    Blizzard = 7777, // ShadowcourtJester->player, 1.0s cast, single-target
    AutoAttack2 = 870, // ChimeraPoppet/ShadowcourtHound->player, no cast, single-target
    Snuggle = 7630, // ChimeraPoppet->player, no cast, single-target
    ParticleBeam = 7464, // Connla->location, no cast, range 5 circle
    BlindingShadow1 = 7476, // Boss->self, 5.0s cast, range 60 circle
    BlindingShadow2 = 7598, // Connla->self, no cast, range 30 circle
    ThirtyCries = 7475, // Boss->players, no cast, range 12 circle
    VoidBlizzard = 7778, // ShadowcourtJester->player, 2.5s cast, single-target
    BigHug = 7631, // ChimeraPoppet->self, 2.5s cast, range 3+R width 3 rect
    TheDragonsVoice = 3344, // ShadowcourtHound->self, 4.5s cast, range 30 circle
}

public enum SID : uint
{
    VulnerabilityUp = 202, // Connla/Boss->player, extra=0x1/0x2
    ShadowLimb = 1148, // Boss->Boss, extra=0x0
    ShadowLinks = 1147, // none->player, extra=0x3C
    Weakness = 43, // none->player, extra=0x0
    Transcendent = 418, // none->player, extra=0x0
    Riled = 1146, // none->Connla/Connla2/Boss, extra=0x0
    Petrification = 610, // none->ShadowLimb, extra=0x0
    EvasionDown = 32, // none->ShadowLimb, extra=0x0

}

public enum IconID : uint
{
    Icon_197 = 197, // player
    Icon_62 = 62, // player
}

public enum TetherID : uint
{
    Tether_2 = 2, // Connla2/ShadowLimb->Boss/player
    Tether_1 = 1, // ShadowLimb->player
}