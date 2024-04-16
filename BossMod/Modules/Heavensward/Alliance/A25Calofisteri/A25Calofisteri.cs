namespace BossMod.Heavensward.Alliance.A25Calofisteri;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4897)]
public class A25Calofisteri(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-300, -35), 30));