using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkTimelessBody : AFeatureMonk {
        public override string Name => "Timeless Body";
        public override string Text => FeatureMonkText.Timeless_Body;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkTimelessBody();
    }
}
