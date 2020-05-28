using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerExtraAttack : AFeatureRanger {
        public override string Name => "Extra Attack";
        public override string Text => FeatureRangerText.Extra_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerExtraAttack();
    }
}
