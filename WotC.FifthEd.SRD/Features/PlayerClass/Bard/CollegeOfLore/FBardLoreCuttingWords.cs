using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public class FBardLoreCuttingWords : AFeatureBardCollegeOfLore {
        public override string Name => "Cutting Words";
        public override string Text => FeatureBardCollegeOfLoreText.Cutting_Words;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardLoreCuttingWords();
    }
}
