using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;
using WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public abstract class FBardBardCollege : AFeatureBard {
        public override string Name => "Bard College";
        public override string Text => FeatureBardText.Bard_College;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public MultiValueDictionary<int, IFeature> CollegeFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FBardLoreBonusProficiencies() },
            { 3, new FBardLoreCuttingWords() },
            { 6, new FBardLoreAdditionalMagicalSecrets() },
            { 14, new FBardLorePeerlessSkill() }
        };
    }
}
