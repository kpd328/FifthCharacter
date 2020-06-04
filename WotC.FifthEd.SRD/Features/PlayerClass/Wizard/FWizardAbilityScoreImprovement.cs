using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public class FWizardAbilityScoreImprovement : AFeatureWizard {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureWizardText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FWizardAbilityScoreImprovement();

        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
