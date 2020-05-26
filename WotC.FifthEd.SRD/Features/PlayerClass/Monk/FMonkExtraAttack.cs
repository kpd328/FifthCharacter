using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkExtraAttack : AFeatureMonk {
        public override string Name => "Extra Attack";
        public override string Text => FeatureMonkText.Extra_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkExtraAttack();
    }
}
