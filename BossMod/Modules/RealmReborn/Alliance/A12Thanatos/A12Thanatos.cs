namespace BossMod.RealmReborn.Alliance.A12Thanatos;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 92, NameID = 710)]
public class A12Thanatos(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(440, 280), 30));