using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardEvocationSculptSpells : AFeatureWizardEvocation {
        public override string Name => "Sculpt Spells";
        public override string Text => FeatureWizardSchoolOfEvocationText.Sculpt_Spells;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWizardEvocationSculptSpells();
    }
}
