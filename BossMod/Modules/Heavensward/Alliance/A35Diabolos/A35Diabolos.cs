namespace BossMod.Heavensward.Alliance.A35Diabolos;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5526)]
public class A35Diabolos(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-330, -445), 35));
