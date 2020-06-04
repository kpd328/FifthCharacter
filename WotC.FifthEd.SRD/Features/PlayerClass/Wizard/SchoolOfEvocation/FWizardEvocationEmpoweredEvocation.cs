using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardEvocationEmpoweredEvocation : AFeatureWizardEvocation {
        public override string Name => "Empowered Evocation";
        public override string Text => FeatureWizardSchoolOfEvocationText.Empowered_Evocation;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardEvocationEmpoweredEvocation();
    }
}
