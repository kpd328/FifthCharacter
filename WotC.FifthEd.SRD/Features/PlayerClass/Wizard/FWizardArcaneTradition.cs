using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Wizard {
    public abstract class FWizardArcaneTradition : AFeatureWizard {
        public override string Name => "Arcane Tradition";
        public override string Text => FeatureWizardText.Arcane_Tradition;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> TraditionFeatures { get; }
    }
}
