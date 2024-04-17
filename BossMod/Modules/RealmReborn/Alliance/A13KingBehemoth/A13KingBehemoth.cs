namespace BossMod.RealmReborn.Alliance.A13KingBehemoth;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 92, NameID = 727)]
public class A13KingBehemoth(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-110, -380), 35))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.IronGiant), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Puroboros), ArenaColor.Enemy);
    }
}