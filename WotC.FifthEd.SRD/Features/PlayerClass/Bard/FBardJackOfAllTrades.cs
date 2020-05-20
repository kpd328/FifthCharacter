using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardJackOfAllTrades : AFeatureBard {
        public override string Name => "Jack of All Trades";
        public override string Text => FeatureBardText.Jack_of_All_Trades;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardJackOfAllTrades();
    }
}
