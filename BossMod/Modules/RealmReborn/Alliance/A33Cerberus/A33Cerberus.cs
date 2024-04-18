namespace BossMod.RealmReborn.Alliance.A33Cerberus;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 111, NameID = 3224)]
public class A33Cerberus(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, -210), 35));