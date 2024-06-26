﻿namespace BossMod.Heavensward.Alliance.A32FerdiadHollow;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5509)]
public class A32FerdiadHollow(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-350, 225), 30))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.FerdiadsFool), ArenaColor.Enemy);
    }
}