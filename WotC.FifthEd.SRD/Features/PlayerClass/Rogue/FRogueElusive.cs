using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueElusive : AFeatureRogue {
        public override string Name => "Elusive";
        public override string Text => FeatureRogueText.Elusive;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueElusive();
    }
}
