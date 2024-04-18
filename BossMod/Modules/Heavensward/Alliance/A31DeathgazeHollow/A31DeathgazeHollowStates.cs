namespace BossMod.Heavensward.Alliance.A31DeathgazeHollow;

class A31DeathgazeHollowStates : StateMachineBuilder
{
    public A31DeathgazeHollowStates(A31DeathgazeHollow module) : base(module)
    {
        TrivialPhase()
            .ActivateOnEnter<VoidAeroII>()
            .ActivateOnEnter<VoidDeath>();
    }
}