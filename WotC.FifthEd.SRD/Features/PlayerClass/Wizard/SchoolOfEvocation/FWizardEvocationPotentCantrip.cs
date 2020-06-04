using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardEvocationPotentCantrip : AFeatureWizardEvocation {
        public override string Name => "Potent Cantrip";
        public override string Text => FeatureWizardSchoolOfEvocationText.Potent_Cantrip;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardEvocationPotentCantrip();
    }
}
