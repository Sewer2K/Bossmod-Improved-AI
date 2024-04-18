namespace BossMod.Heavensward.Alliance.A11Cetus;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 120, NameID = 4613)]
public class A11Cetus(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-288, -3), 35))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.HybodusPup), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Hybodus), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Hydrosphere), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Hydrocore), ArenaColor.Enemy);
    }
}