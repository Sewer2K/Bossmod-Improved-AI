namespace BossMod.Shadowbringers.Alliance.A34RedGirlP2;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 779, NameID = 9950)]
public class A34RedGirlP2(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(845, -850), 20));