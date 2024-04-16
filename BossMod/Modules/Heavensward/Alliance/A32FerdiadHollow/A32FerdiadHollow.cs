namespace BossMod.Heavensward.Alliance.A32FerdiadHollow;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5509)]
public class A32FerdiadHollow(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-350, 225), 30));