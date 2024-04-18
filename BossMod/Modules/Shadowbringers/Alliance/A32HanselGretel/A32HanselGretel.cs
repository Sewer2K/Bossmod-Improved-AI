namespace BossMod.Shadowbringers.Alliance.A32HanselGretel;

[ModuleInfo(BossModuleInfo.Maturity.Contributed, Contributors = "CombatReborn Team", PrimaryActorOID = (uint)OID.Gretel, GroupType = BossModuleInfo.GroupType.CFC, GroupID = 779, NameID = 9990)] // 9990 is HanselGretel, 9988 is Hansel, 9989 is Gretel
public class A32HanselGretel(WorldState ws, Actor primary) : BossModule(ws, primary, new ArenaBoundsCircle(new(-800, -950), 30))
{
    private Actor? _hansel;

    public Actor? Gretel() => PrimaryActor;
    public Actor? Hansel() => _hansel;

    protected override void UpdateModule()
    {
        //copied and adapted from A22AlthykNymeia.cs
        _hansel ??= StateMachine.ActivePhaseIndex == 0 ? Enemies(OID.Hansel).FirstOrDefault() : null;
    }

    protected override void DrawEnemies(int pcSlot, Actor pc)
    {
        Arena.Actor(PrimaryActor, ArenaColor.Enemy);
        Arena.Actor(_hansel, ArenaColor.Enemy);
    }
}