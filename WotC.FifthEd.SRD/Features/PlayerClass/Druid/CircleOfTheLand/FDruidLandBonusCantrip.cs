using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandBonusCantrip : AFeatureDruidCircleOfTheLand {
        //TODO: Prompt for new cantrip
        public override string Name => "Bonus Cantrip";
        public override string Text => FeatureDruidCircleOfTheLandText.Bonus_Cantrip;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandBonusCantrip();
    }
}
