using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianExtraAttack : AFeatureBarbarian {
        public override string Name => "Extra Attack";
        public override string Text => FeatureBarbarianText.Extra_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianExtraAttack();
    }
}
