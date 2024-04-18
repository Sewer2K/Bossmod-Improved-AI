namespace BossMod.Heavensward.Alliance.A31DeathgazeHollow;

class VoidDeath(BossModule module) : Components.SelfTargetedAOEs(module, ActionID.MakeSpell(AID.VoidDeath), new AOEShapeCircle(10));
class VoidAeroII(BossModule module) : Components.BaitAwayCast(module, ActionID.MakeSpell(AID.VoidAeroII), new AOEShapeCircle(5), true);

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", GroupType = BossModuleInfo.GroupType.CFC, GroupID = 220, NameID = 5507)]
public class A31DeathgazeHollow(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsRect(new(300, 410), 30, 15))
{
    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actors(Enemies(OID.Boss), ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.VoidSprite), ArenaColor.Enemy);
    }
}