using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerAbilityScoreImprovement : AFeatureRanger {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureRangerText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FRangerAbilityScoreImprovement();

        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
