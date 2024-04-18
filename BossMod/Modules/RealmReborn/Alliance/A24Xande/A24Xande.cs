namespace BossMod.RealmReborn.Alliance.A24Xande;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 102, NameID = 2824)]
public class A24Xande(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-288, -3), 35));