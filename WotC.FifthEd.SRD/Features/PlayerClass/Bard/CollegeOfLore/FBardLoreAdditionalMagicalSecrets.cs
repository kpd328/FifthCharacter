using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public class FBardLoreAdditionalMagicalSecrets : AFeatureBardCollegeOfLore {
        public override string Name => "Additional Magical Secrets";
        public override string Text => FeatureBardCollegeOfLoreText.Additional_Magical_Secrets;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardLoreAdditionalMagicalSecrets();
    }
}
