﻿namespace BossMod.Endwalker.Alliance.A33Oschon;

class Phase2ArenaUpdate(BossModule module) : BossComponent(module)
{
    public override void OnEventEnvControl(byte index, uint state)
    {
        if (state == 0x00200010 && index == 0x42)
            Module.Arena.Bounds = new ArenaBoundsSquare(Module.Bounds.Center, 20);
    }
}

class A33OschonStates : StateMachineBuilder
{
    private readonly A33Oschon _module;

    public A33OschonStates(A33Oschon module) : base(module)
    {
        _module = module;
        SimplePhase(0, id => { SimpleState(id, 10000, "Enrage"); }, "P1")
            .ActivateOnEnter<TrekShot>()
            .ActivateOnEnter<TrekShot2>()
            .ActivateOnEnter<SuddenDownpour>()
            .ActivateOnEnter<DownhillP1>()
            .ActivateOnEnter<ClimbingShot>()
            .ActivateOnEnter<ClimbingShotRaidwide>()
            .ActivateOnEnter<ClimbingShotRaidwide2>()
            .ActivateOnEnter<ClimbingShotRaidwide3>()
            .ActivateOnEnter<ClimbingShotRaidwide4>()
            .ActivateOnEnter<SoaringMinuet1>()
            .ActivateOnEnter<SoaringMinuet2>()
            .ActivateOnEnter<FlintedFoehnP1>()
            .ActivateOnEnter<TheArrow>()
            .ActivateOnEnter<SwingingDraw>()
            .ActivateOnEnter<LoftyPeaks>()
            .Raw.Update = () => !Module.PrimaryActor.IsTargetable;
        SimplePhase(1, id => { SimpleState(id, 10000, "Enrage"); }, "P2")
            .ActivateOnEnter<Phase2ArenaUpdate>()
            .ActivateOnEnter<PitonPull>()
            .ActivateOnEnter<Altitude>()
            .ActivateOnEnter<GreatWhirlwind>()
            .ActivateOnEnter<DownhillSmall>()
            .ActivateOnEnter<DownhillBig>()
            .ActivateOnEnter<ArrowTrail>()
            .ActivateOnEnter<WanderingVolley>()
            .ActivateOnEnter<WanderingVolleyAOE>()
            .ActivateOnEnter<WanderingVolleyRaidwide1>()
            .ActivateOnEnter<WanderingVolleyRaidwide2>()
            .ActivateOnEnter<TheArrowP2>()
            .ActivateOnEnter<FlintedFoehnP2>()
            .Raw.Update = () => _module.OschonP2 != null && _module.OschonP2()?.HP.Cur == 1;
    }
}
