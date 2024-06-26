﻿namespace BossMod.RealmReborn.Trial.T08ThornmarchH;

class MoogleGoRound(BossModule module) : Components.GenericAOEs(module)
{
    private List<Actor> _casters = new();
    private static readonly AOEShape _shape = new AOEShapeCircle(20);

    public override IEnumerable<AOEInstance> ActiveAOEs(int slot, Actor actor)
    {
        return _casters.Take(2).Select(c => new AOEInstance(_shape, c.Position, c.CastInfo!.Rotation, c.CastInfo!.NPCFinishAt));
    }

    public override void AddAIHints(int slot, Actor actor, PartyRolesConfig.Assignment assignment, AIHints hints)
    {
        base.AddAIHints(slot, actor, assignment, hints);

        // if there is a third cast, add a smaller shape to ensure people stay closer to eventual safespot
        if (_casters.Count > 2)
        {
            var f1 = ShapeDistance.InvertedCircle(_casters[0].Position, 23);
            var f2 = ShapeDistance.Circle(_casters[2].Position, 10);
            hints.AddForbiddenZone(p => Math.Min(f1(p), f2(p)), _casters[1].CastInfo!.NPCFinishAt);
        }
    }

    public override void OnCastStarted(Actor caster, ActorCastInfo spell)
    {
        if ((AID)spell.Action.ID is AID.MoogleGoRoundBoss or AID.MoogleGoRoundAdd)
            _casters.Add(caster);
    }

    public override void OnCastFinished(Actor caster, ActorCastInfo spell)
    {
        if ((AID)spell.Action.ID is AID.MoogleGoRoundBoss or AID.MoogleGoRoundAdd)
            _casters.Remove(caster);
    }
}
