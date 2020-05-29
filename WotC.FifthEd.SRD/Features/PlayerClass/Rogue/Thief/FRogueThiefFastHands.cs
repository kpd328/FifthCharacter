using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueThiefFastHands : AFeatureRogueThief {
        public override string Name => "Fast Hands";
        public override string Text => FeatureRogueThiefText.Fast_Hands;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueThiefFastHands();
    }
}
