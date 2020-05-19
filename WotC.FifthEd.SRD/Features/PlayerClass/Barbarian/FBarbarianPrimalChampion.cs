using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianPrimalChampion : AFeatureBarbarian {
        public override string Name => "Primal Champion";
        public override string Text => FeatureBarbarianText.Primal_Champion;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public override bool IsAbilityMod => true;

        public override IFeature GetInstance() => new FBarbarianPrimalChampion();

        public override void ModAbility() {
            AbilityManager.StrengthScore += 4;
            AbilityManager.ConstitutionScore += 4;
        }
    }
}
