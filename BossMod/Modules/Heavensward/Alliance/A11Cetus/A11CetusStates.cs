namespace BossMod.Heavensward.Alliance.A11Cetus;

class A11CetusStates : StateMachineBuilder
{
    public A11CetusStates(BossModule module) : base(module)
    {
        TrivialPhase();
    }
}