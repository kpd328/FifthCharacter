using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public class FBardLorePeerlessSkill : AFeatureBardCollegeOfLore {
        public override string Name => "Peerless Skill";
        public override string Text => FeatureBardCollegeOfLoreText.Peerless_Skill;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardLorePeerlessSkill();
    }
}
