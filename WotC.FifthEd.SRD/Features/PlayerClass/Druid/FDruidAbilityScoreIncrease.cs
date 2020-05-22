using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidAbilityScoreIncrease : AFeatureDruid {
        public override string Name => FAbilityScoreImprovement.Name;
        public override string Text => FeatureDruidText.Ability_Score_Improvement;
        public override bool IsActive => FAbilityScoreImprovement.IsActive;
        public override int ActiveUses => FAbilityScoreImprovement.ActiveUses;
        public override bool IsAbilityMod => FAbilityScoreImprovement.IsAbilityMod;

        public override IFeature GetInstance() => new FDruidAbilityScoreIncrease();

        public override void ModAbility() => FAbilityScoreImprovement.ModAbility();
    }
}
