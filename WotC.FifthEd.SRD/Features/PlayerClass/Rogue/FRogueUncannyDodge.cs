using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueUncannyDodge : AFeatureRogue {
        public override string Name => "Uncanny Dodge";
        public override string Text => FeatureRogueText.Uncanny_Dodge;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueUncannyDodge();
    }
}
