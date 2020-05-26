using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public class FFighterExtraAttack : AFeatureFighter {
        public override string Name => "Extra Attack";
        public override string Text => FeatureFighterText.Extra_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FFighterExtraAttack();
    }
}
