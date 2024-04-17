namespace BossMod.RealmReborn.Alliance.A11BoneDragon;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 92, NameID = 706)]
public class A11BoneDragon(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-450, 20), 20))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Platinal), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.RottingEye), ArenaColor.Enemy);
    }
}