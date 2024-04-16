namespace BossMod.Heavensward.Alliance.A24Ozma;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4896)]
public class A24Ozma(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(280, -410), 30));