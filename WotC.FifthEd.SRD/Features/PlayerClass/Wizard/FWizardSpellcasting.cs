using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public class FWizardSpellcasting : AFeatureWizard {
        public override string Name => "Spellcasting";
        public override string Text => FeatureWizardText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardSpellcasting();
    }
}
