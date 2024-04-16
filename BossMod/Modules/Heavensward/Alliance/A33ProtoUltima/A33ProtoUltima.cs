namespace BossMod.Heavensward.Alliance.A33ProtoUltima;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 3780)]
public class A33ProtoUltima(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-350, -50), 30));