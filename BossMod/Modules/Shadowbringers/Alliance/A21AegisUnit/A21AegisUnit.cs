namespace BossMod.Shadowbringers.Alliance.A21AegisUnit;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 736, NameID = 9642)]
public class A21AegisUnit(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-230, 190), 30));