using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    class FFighterAbilityScoreImprovement : AFeatureFighter {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureFighterText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FFighterAbilityScoreImprovement();
        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
