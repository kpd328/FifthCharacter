using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandLandsStride : AFeatureDruidCircleOfTheLand {
        public override string Name => "Land's Stride";
        public override string Text => FeatureDruidCircleOfTheLandText.Lands_Stride;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandLandsStride();
    }
}
