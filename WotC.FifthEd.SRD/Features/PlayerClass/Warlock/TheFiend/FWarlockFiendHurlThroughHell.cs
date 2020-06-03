using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockFiendHurlThroughHell : AFeatureWarlockFiend {
        public override string Name => "Hurl Through Hell";
        public override string Text => FeatureWarlockFiendText.Hurl_Through_Hell;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FWarlockFiendHurlThroughHell();
    }
}
