using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinExtraAttack : AFeaturePaladin {
        public override string Name => "Extra Attack";
        public override string Text => FeaturePaladinText.Extra_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinExtraAttack();
    }
}
