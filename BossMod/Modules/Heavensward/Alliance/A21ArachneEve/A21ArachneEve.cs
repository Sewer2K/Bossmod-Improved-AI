namespace BossMod.Heavensward.Alliance.A21ArachneEve;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4871)]
public class A21ArachneEve(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(16, -60), 35));