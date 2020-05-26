using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public class FMonkOpenHandTranquility : AFeatureMonkWayOfTheOpenHand {
        public override string Name => "Tranquility";
        public override string Text => FeatureMonkWayOfTheOpenHandText.Tranquility;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkOpenHandTranquility();
    }
}
