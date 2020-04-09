using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public class FFighterSecondWind : AFeatureFighter {
        public override string Name => "Second Wind";
        public override string Text => FeatureFighterText.SecondWind;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FFighterSecondWind();
    }
}
