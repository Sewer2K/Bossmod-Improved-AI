﻿namespace BossMod.Heavensward.Alliance.A21ArachneEve;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4871)]
public class A21ArachneEve(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(20, -60), 30))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Keyknot), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Webmaiden), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.SpittingSpider), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.SkitteringSpider), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.EarthAether), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.DeepEarthAether), ArenaColor.Enemy);
    }
}