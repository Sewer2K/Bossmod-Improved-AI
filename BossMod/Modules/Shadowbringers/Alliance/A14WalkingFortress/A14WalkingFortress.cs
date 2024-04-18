namespace BossMod.Shadowbringers.Alliance.A14WalkingFortress;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 700, NameID = 9153)]
public class A14WalkingFortress(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(900, 425), 30));