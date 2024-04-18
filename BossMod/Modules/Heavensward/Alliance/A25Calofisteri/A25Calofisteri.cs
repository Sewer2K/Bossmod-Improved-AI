namespace BossMod.Heavensward.Alliance.A25Calofisteri;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4897)]
public class A25Calofisteri(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-300, -35), 30))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Bijou1), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Bijou2), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.GrandBijou), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.LivingLock1), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.LivingLock2), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.LivingLock3), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.LurkingLock), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Entanglement), ArenaColor.Enemy);
    }
}