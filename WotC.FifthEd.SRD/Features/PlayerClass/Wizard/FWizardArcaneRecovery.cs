using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public class FWizardArcaneRecovery : AFeatureWizard {
        public override string Name => "Arcane Recovery";
        public override string Text => FeatureWizardText.Arcane_Recovery;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FWizardArcaneRecovery();
    }
}
