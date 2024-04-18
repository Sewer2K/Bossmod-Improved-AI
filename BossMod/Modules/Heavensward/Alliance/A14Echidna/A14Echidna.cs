namespace BossMod.Heavensward.Alliance.A14Echidna;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 120, NameID = 4631)]
public class A14Echidna(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(285, -130), 35))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Dexter), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Sinister), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Bloodguard), ArenaColor.Enemy);
    }
}