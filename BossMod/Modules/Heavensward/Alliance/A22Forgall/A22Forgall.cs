namespace BossMod.Heavensward.Alliance.A22Forgall;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4878)]
public class A22Forgall(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-300, -422), 30));