using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkUnarmoredMovement : AFeatureMonk {
        public override string Name => "Unarmored Movement";
        public override string Text => FeatureMonkText.Unarmored_Movement;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkUnarmoredMovement();
    }
}
