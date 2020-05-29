using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueEvasion : AFeatureRogue {
        public override string Name => "Evasion";
        public override string Text => FeatureRogueText.Evasion;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueEvasion();
    }
}
