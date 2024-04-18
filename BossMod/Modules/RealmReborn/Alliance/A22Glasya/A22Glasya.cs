namespace BossMod.RealmReborn.Alliance.A22Glasya;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 102, NameID = 2815)]
public class A22Glasya(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, -200), 35));