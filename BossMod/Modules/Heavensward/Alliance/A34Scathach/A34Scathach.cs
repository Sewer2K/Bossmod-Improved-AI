namespace BossMod.Heavensward.Alliance.A34Scathach;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5515)]
public class A34Scathach(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, -50), 30));