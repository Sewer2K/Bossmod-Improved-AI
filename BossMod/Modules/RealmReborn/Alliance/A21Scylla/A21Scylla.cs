namespace BossMod.RealmReborn.Alliance.A21Scylla;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 102, NameID = 2809)]
public class A21Scylla(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, -192), 35));