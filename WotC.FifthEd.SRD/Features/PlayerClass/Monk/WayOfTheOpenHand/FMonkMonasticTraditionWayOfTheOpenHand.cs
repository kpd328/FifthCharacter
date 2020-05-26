using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public class FMonkMonasticTraditionWayOfTheOpenHand : FMonkMonasticTradition {
        public override string Name => "Monastic Tradition: Way of the Open Hand";
        public override string Text => FeatureMonkWayOfTheOpenHandText.Way_of_the_Open_Hand;
        public override MultiValueDictionary<int, IFeature> TraditionFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FMonkOpenHandOpenHandTechnique() },
            { 6, new FMonkOpenHandWholenessOfBody() },
            { 11, new FMonkOpenHandTranquility() },
            { 17, new FMonkOpenHandQuiveringPalm() }
        };

        public override IFeature GetInstance() => new FMonkMonasticTraditionWayOfTheOpenHand();
    }
}
