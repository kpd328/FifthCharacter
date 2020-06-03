using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public abstract class FWarlockOtherworldlyPatron : AFeatureWarlock {
        public override string Name => "Otherworldly Patron";
        public override string Text => FeatureWarlockText.Otherworldly_Patron;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> PatronFeatures { get; }
    }
}
