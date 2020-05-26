using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public class FMonkOpenHandOpenHandTechnique : AFeatureMonkWayOfTheOpenHand {
        public override string Name => "Open Hand Technique";
        public override string Text => FeatureMonkWayOfTheOpenHandText.Open_Hand_Technique;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkOpenHandOpenHandTechnique();
    }
}
