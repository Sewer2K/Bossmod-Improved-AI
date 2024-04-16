namespace BossMod.Heavensward.Alliance.A23Headstone;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4868)]
public class A23Headstone(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-160, 220), 40));