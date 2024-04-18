namespace BossMod.Shadowbringers.Alliance.A23ArtilleryUnit;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 736, NameID = 9650)]
public class A23ArtilleryUnit(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(200, -115), 30));