﻿namespace BossMod.Shadowbringers.Foray.DelubrumReginae.Normal.DRN1TrinitySeeker;

class BalefulSwathe(BossModule module) : Components.GenericAOEs(module, ActionID.MakeSpell(AID.BalefulSwathe))
{
    private DateTime _activation = module.WorldState.FutureTime(7.6f); // from verdant path cast start
    private static readonly AOEShapeRect _shape = new(50, 50, -5);

    public override IEnumerable<AOEInstance> ActiveAOEs(int slot, Actor actor)
    {
        yield return new(_shape, Module.PrimaryActor.Position, Module.PrimaryActor.Rotation + 90.Degrees(), _activation);
        yield return new(_shape, Module.PrimaryActor.Position, Module.PrimaryActor.Rotation - 90.Degrees(), _activation);
    }
}
