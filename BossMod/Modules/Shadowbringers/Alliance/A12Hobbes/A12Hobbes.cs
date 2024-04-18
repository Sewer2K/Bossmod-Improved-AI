namespace BossMod.Shadowbringers.Alliance.A12Hobbes;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 700, NameID = 9143)] //9144 and 9145 also listed as Hobbes
public class A12Hobbes(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-805, -240), 30));