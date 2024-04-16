namespace BossMod.Heavensward.Alliance.A21ArachneEve;

class A21ArachneEveStates : StateMachineBuilder
{
    public A21ArachneEveStates(BossModule module) : base(module)
    {
        TrivialPhase();
    }
}