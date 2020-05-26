using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public abstract class FMonkMonasticTradition : AFeatureMonk {
        public override string Name => "Monastic Tradition";
        public override string Text => FeatureMonkText.Monastic_Tradition;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> TraditionFeatures { get; }
    }
}
