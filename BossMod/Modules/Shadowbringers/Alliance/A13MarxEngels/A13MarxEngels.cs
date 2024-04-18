namespace BossMod.Shadowbringers.Alliance.A13MarxEngels;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 700, NameID = 9147)] // 9150 Marx L, 9151 Marx R, 1952 and 1957 Marx
public class A13MarxEngels(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(900, 670), 30));