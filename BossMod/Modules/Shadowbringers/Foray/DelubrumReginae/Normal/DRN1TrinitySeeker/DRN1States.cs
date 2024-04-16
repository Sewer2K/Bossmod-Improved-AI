namespace BossMod.Shadowbringers.Foray.DelubrumReginae.Normal.DRN1TrinitySeeker;

class DRN1States : StateMachineBuilder
{
    public DRN1States(BossModule module) : base(module)
    {
        TrivialPhase()
            .ActivateOnEnter<VerdantTempest>()
            .ActivateOnEnter<MercifulBreeze>()
            .ActivateOnEnter<MercifulBlooms>()
            .ActivateOnEnter<MercifulArc>()
            .ActivateOnEnter<BurningChains>()
            .ActivateOnEnter<IronImpact>()
            .ActivateOnEnter<IronRose>()
            .ActivateOnEnter<DeadIron>()
            .ActivateOnEnter<ActOfMercy>()
            .ActivateOnEnter<BalefulBlade>()
            .ActivateOnEnter<BalefulSwathe>()
            .ActivateOnEnter<IronSplitter>()
            .ActivateOnEnter<MercifulMoon>()
            .ActivateOnEnter<MercyFourfold>();
    }
}
