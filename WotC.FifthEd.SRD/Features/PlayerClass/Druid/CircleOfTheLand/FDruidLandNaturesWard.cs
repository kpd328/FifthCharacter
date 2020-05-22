using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandNaturesWard : AFeatureDruidCircleOfTheLand {
        public override string Name => "Nature's Ward";
        public override string Text => FeatureDruidCircleOfTheLandText.Natures_Ward;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandNaturesWard();
    }
}
