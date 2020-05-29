using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueAbilityScoreImprovement : AFeatureRogue {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureRogueText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FRogueAbilityScoreImprovement();

        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
