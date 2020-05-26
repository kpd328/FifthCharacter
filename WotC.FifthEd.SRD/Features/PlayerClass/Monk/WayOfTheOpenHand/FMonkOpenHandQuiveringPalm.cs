using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public class FMonkOpenHandQuiveringPalm : AFeatureMonkWayOfTheOpenHand {
        public override string Name => "Quivering Palm";
        public override string Text => FeatureMonkWayOfTheOpenHandText.Quivering_Palm;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkOpenHandQuiveringPalm();
    }
}
