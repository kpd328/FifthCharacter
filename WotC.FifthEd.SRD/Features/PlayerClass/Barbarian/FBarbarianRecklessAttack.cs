using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianRecklessAttack : AFeatureBarbarian {
        public override string Name => "Reckless Attack";
        public override string Text => FeatureBarbarianText.Reckless_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianRecklessAttack();
    }
}
