using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandNaturalRecovery : AFeatureDruidCircleOfTheLand {
        public override string Name => "Natural Recovery";
        public override string Text => FeatureDruidCircleOfTheLandText.Natural_Recovery;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandNaturalRecovery();
    }
}
