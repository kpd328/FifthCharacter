using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianFastMovement : AFeatureBarbarian {
        //TODO: Implement system to add 10ft of movement iff heavy armor is not being worn (meaning not affecting AC)
        public override string Name => "Fast Movement";
        public override string Text => FeatureBarbarianText.Fast_Movement;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianFastMovement();
    }
}
