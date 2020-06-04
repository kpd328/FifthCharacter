using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public class FWizardSignatureSpells : AFeatureWizard {
        public override string Name => "Signature Spells";
        public override string Text => FeatureWizardText.Signature_Spells;
        public override bool IsActive => true;
        public override int ActiveUses => 2;

        public override IFeature GetInstance() => new FWizardSignatureSpells();
    }
}
