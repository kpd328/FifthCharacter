using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueSneakAttack : AFeatureRogue {
        public override string Name => "Sneak Attack";
        public override string Text => FeatureRogueText.Sneak_Attack;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueSneakAttack();
    }
}
