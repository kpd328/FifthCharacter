using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidDruidCircleCircleOfTheLand : FDruidDruidCircle {
        public override string Name => "Druid Circle: Circle Of The Land";
        public override string Text => FeatureDruidCircleOfTheLandText.Circle_of_the_Land;
        public override MultiValueDictionary<int, IFeature> CircleFeatures => new MultiValueDictionary<int, IFeature>() {
            { 2, new FDruidLandBonusCantrip() },
            { 2, new FDruidLandNaturalRecovery() },
            { 3, new FDruidLandCircleSpells() },
            { 6, new FDruidLandLandsStride() },
            { 10, new FDruidLandNaturesWard() },
            { 14, new FDruidLandNaturesSanctuary() }
        };

        public override IFeature GetInstance() => new FDruidDruidCircleCircleOfTheLand();
    }
}
