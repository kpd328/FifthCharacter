using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianDangerSense : AFeatureBarbarian {
        public override string Name => "Danger Sense";
        public override string Text => FeatureBarbarianText.Danger_Sense;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianDangerSense();
    }
}
