namespace BossMod.Heavensward.Alliance.A14Echidna;

class A14EchidnaStates : StateMachineBuilder
{
    public A14EchidnaStates(BossModule module) : base(module)
    {
        TrivialPhase();
    }
}