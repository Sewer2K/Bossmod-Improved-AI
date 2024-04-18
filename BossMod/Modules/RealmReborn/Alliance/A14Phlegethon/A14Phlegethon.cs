namespace BossMod.RealmReborn.Alliance.A14Phlegethon;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 92, NameID = 732)]
public class A14Phlegethon(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-110, 180), 35));