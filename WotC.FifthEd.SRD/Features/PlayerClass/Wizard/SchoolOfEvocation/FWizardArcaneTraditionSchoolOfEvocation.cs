using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard.SchoolOfEvocation {
    public class FWizardArcaneTraditionSchoolOfEvocation : FWizardArcaneTradition {
        public override string Name => "Arcane Tradition: School of Evocation";
        public override string Text => FeatureWizardSchoolOfEvocationText.School_of_Evocation;
        public override MultiValueDictionary<int, IFeature> TraditionFeatures => new MultiValueDictionary<int, IFeature>() {
            { 2, new FWizardEvocationEvocationSavant() },
            { 2, new FWizardEvocationSculptSpells() },
            { 6, new FWizardEvocationPotentCantrip() },
            { 10, new FWizardEvocationEmpoweredEvocation() },
            { 14, new FWizardEvocationOverchannel() }
        };

        public override IFeature GetInstance() => new FWizardArcaneTraditionSchoolOfEvocation();
    }
}
