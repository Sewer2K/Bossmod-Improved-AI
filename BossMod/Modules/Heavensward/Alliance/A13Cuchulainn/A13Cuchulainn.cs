namespace BossMod.Heavensward.Alliance.A13Cuchulainn;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "LTS", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 120, NameID = 4626)]
public class A13Cuchulainn(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(287.984f, 138.750f), 35))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Foobar), ArenaColor.Enemy);

    }
}