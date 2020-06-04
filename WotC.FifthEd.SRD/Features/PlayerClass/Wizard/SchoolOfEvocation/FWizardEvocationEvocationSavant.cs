using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardEvocationEvocationSavant : AFeatureWizardEvocation {
        public override string Name => "Evocation Savant";
        public override string Text => FeatureWizardSchoolOfEvocationText.Evocation_Savant;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardEvocationEvocationSavant();
    }
}
