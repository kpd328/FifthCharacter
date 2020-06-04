using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardEvocationOverchannel : AFeatureWizardEvocation {
        public override string Name => "Overchannel";
        public override string Text => FeatureWizardSchoolOfEvocationText.Overchannel;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FWizardEvocationOverchannel();
    }
}
