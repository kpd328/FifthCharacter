using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public class FBardBardCollegeCollegeOfLore : FBardBardCollege {
        public override string Name => "Bard College: College of Lore";
        public override string Text => FeatureBardCollegeOfLoreText.College_of_Lore;

        public override IFeature GetInstance() => new FBardBardCollegeCollegeOfLore();
    }
}
