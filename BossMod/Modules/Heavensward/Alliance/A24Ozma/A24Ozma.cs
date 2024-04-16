namespace BossMod.Heavensward.Alliance.A24Ozma;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 168, NameID = 4896)]
public class A24Ozma(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(280, -410), 30))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.SingularityFragment), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.SingularityEcho), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.SingularityRipple), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Ozmasphere), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Ozmashade), ArenaColor.Enemy);
    }
}