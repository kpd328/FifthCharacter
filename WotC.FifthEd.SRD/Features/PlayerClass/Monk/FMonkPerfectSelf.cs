using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkPerfectSelf : AFeatureMonk {
        //TODO: add functionality to restore 4 Ki uses on activation
        public override string Name => "Perfect Self";
        public override string Text => FeatureMonkText.Perfect_Self;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkPerfectSelf();
    }
}
