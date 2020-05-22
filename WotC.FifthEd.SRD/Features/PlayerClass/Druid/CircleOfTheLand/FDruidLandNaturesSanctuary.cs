using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandNaturesSanctuary : AFeatureDruidCircleOfTheLand {
        public override string Name => "Nature's Sanctuary";
        public override string Text => FeatureDruidCircleOfTheLandText.Natures_Sanctuary;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandNaturesSanctuary();
    }
}
