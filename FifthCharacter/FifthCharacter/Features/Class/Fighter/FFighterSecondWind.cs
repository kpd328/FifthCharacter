namespace FifthCharacter.Features.Class.Fighter {
    public class FFighterSecondWind : AFeatureFighter {
        public override string Name => "Second Wind";
        public override string Text => FeatureFighterText.SecondWind;
        public override bool IsActive => true;
        public override int ActiveUses => 1;
    }
}
