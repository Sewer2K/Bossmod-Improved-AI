﻿namespace BossMod.Shadowbringers.Foray.DelubrumReginae.Savage.DRS2StygimolochWarrior;

class ViciousSwipe(BossModule module) : Components.SelfTargetedAOEs(module, ActionID.MakeSpell(AID.ViciousSwipe), new AOEShapeCircle(15));
class CrazedRampage(BossModule module) : Components.KnockbackFromCastTarget(module, ActionID.MakeSpell(AID.CrazedRampage), 13);
class Coerce(BossModule module) : Components.StatusDrivenForcedMarch(module, 4, (uint)SID.ForwardMarch, (uint)SID.AboutFace, (uint)SID.LeftFace, (uint)SID.RightFace);

[ModuleInfo(BossModuleInfo.Maturity.Verified, GroupType = BossModuleInfo.GroupType.CFC, GroupID = 761, NameID = 9754)]
public class DRS2(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsSquare(new(-160, 78), 17.5f));
