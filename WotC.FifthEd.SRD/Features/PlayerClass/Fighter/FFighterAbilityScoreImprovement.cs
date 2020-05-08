using FifthCharacter.Plugin.Interface;
using System;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    class FFighterAbilityScoreImprovement : AFeatureFighter {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureFighterText.AbilityScoreImprovement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public new bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FFighterAbilityScoreImprovement();
        public new void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
