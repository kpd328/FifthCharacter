using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public class FFighterActionSurge : AFeatureFighter {
        public override string Name => "Action Surge";
        public override string Text => FeatureFighterText.ActionSurge;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FFighterActionSurge();
    }
}
