using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinAbilityScoreImprovement : AFeaturePaladin {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeaturePaladinText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FPaladinAbilityScoreImprovement();
        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
