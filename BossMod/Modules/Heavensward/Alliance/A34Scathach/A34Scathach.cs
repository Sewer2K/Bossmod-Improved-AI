namespace BossMod.Heavensward.Alliance.A34Scathach;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5515)]
public class A34Scathach(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, -50), 30))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Connla), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.Connla2), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.ShadowLimb), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.ShadowcourtJester), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.ChimeraPoppet), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.ShadowcourtHound), ArenaColor.Enemy);
    }
}