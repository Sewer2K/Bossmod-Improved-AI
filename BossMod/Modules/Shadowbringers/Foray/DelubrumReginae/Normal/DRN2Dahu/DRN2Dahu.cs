namespace BossMod.Modules.Shadowbringers.Foray.DelubrumReginae.Normal.DRN2Dahu
{
    class DahuStates : StateMachineBuilder
    {
        public DahuStates(BossModule module) : base(module)
        {
            TrivialPhase();
        }
    }

    [ModuleInfo(BossModuleInfo.Maturity.WIP, GroupType = BossModuleInfo.GroupType.CFC, GroupID = 760, NameID = 9751)]
    public class Dahu : BossModule
    {
        public Dahu(WorldState ws, Actor primary) : base(ws, primary, new ArenaBoundsCircle(new(100, 100), 20)) { }
    }
}
