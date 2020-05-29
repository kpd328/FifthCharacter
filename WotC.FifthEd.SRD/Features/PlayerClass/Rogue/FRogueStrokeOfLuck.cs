using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueStrokeOfLuck : AFeatureRogue {
        public override string Name => "Stroke of Luck";
        public override string Text => FeatureRogueText.Stroke_of_Luck;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FRogueStrokeOfLuck();
    }
}
