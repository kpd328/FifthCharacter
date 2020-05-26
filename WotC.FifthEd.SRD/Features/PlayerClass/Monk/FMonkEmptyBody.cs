using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkEmptyBody : AFeatureMonk {
        public override string Name => "Empty Body";
        public override string Text => FeatureMonkText.Empty_Body;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkEmptyBody();
    }
}
