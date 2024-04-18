namespace BossMod.Heavensward.Alliance.A23Headstone;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4868)]
public class A23Headstone(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-160, 220), 40))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Parthenope), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.VoidFire), ArenaColor.Enemy);
    }
}