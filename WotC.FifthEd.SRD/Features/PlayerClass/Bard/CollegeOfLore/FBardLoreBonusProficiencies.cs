using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public class FBardLoreBonusProficiencies : AFeatureBardCollegeOfLore {
        public override string Name => "Bonus Proficiencies";
        public override string Text => FeatureBardCollegeOfLoreText.Bonus_Proficiencies;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardLoreBonusProficiencies();
    }
}
