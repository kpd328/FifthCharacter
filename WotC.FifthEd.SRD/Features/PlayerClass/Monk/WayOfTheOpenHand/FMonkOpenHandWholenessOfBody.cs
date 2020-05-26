using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public class FMonkOpenHandWholenessOfBody : AFeatureMonkWayOfTheOpenHand {
        public override string Name => "Wholeness of Body";
        public override string Text => FeatureMonkWayOfTheOpenHandText.Wholeness_of_Body;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FMonkOpenHandWholenessOfBody();
    }
}
