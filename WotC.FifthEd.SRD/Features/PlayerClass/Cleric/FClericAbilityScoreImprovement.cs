using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public class FClericAbilityScoreImprovement : AFeatureCleric {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureClericText.Ability_Score_Increase;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FClericAbilityScoreImprovement();

        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
