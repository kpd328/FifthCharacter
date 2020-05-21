using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeBonusProficiency : AFeatureClericLifeDomain {
        public override string Name => "Bonus Proficiency";
        public override string Text => FeatureClericLifeDomainText.Bonus_Proficiency;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FClericLifeBonusProficiency() { }

        public FClericLifeBonusProficiency(bool isTaken) {
            ProficiencyManager.Proficiencies.Add(new ProfArmorHeavy("Class Cleric (Life Domain)"));
        }

        public override IFeature GetInstance() => new FClericLifeBonusProficiency(true);
    }
}
