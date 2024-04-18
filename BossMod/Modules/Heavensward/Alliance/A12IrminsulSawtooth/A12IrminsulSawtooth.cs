namespace BossMod.Heavensward.Alliance.A12IrminsulSawtooth;

[ModuleInfo(BossModuleInfo.Maturity.WIP, Contributors = "CombatReborn Team", PrimaryActorOID = (uint)OID.Irminsul, GroupType = BossModuleInfo.GroupType.CFC, GroupID = 120, NameID = 4623)]
public class A12IrminsulSawtooth(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(0, 130), 35))
{
    private Actor? _sawtooth;

    public Actor? Irminsul() => PrimaryActor;
    public Actor? Sawtooth() => _sawtooth;

    protected override void UpdateModule()
    {
        _sawtooth ??= StateMachine.ActivePhaseIndex == 0 ? Enemies(OID.Sawtooth).FirstOrDefault() : null;
    }

    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actor(PrimaryActor, ArenaColor.Enemy);
        Arena.Actor(_sawtooth, ArenaColor.Enemy);
        Arena.Actors(Enemies(OID.ArkKed), ArenaColor.Enemy);
    }
}