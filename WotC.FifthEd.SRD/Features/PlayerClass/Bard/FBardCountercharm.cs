using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardCountercharm : AFeatureBard {
        public override string Name => "Countercharm";
        public override string Text => FeatureBardText.Countercharm;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardCountercharm();
    }
}
