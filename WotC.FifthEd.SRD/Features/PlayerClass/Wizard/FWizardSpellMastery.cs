using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public class FWizardSpellMastery : AFeatureWizard {
        public override string Name => "Spell Mastery";
        public override string Text => FeatureWizardText.Spell_Mastery;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardSpellMastery();
    }
}
