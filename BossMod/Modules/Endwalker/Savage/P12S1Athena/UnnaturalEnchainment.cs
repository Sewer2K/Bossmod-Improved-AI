﻿namespace BossMod.Endwalker.Savage.P12S1Athena;

// TODO: consider using envcontrols instead
class UnnaturalEnchainment(BossModule module) : Components.GenericAOEs(module, ActionID.MakeSpell(AID.Sample))
{
    private List<AOEInstance> _aoes = new();

    private static readonly AOEShapeRect _shape = new(5, 10, 5);

    public override IEnumerable<AOEInstance> ActiveAOEs(int slot, Actor actor) => _aoes;

    public override void OnTethered(Actor source, ActorTetherInfo tether)
    {
        if (tether.ID == (uint)TetherID.UnnaturalEnchainment)
            _aoes.Add(new(_shape, source.Position, default, WorldState.FutureTime(8.2f)));
    }
}
