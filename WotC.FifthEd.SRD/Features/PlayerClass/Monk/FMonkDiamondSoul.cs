using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkDiamondSoul : AFeatureMonk {
        public override string Name => "Diamond Soul";
        public override string Text => FeatureMonkText.Diamond_Soul;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FMonkDiamondSoul() { }

        public FMonkDiamondSoul(bool _) {
            ProficiencyManager.Proficiencies.Add(new ProfStrengthSave("Class Monk"));
            ProficiencyManager.Proficiencies.Add(new ProfDexteritySave("Class Monk"));
            ProficiencyManager.Proficiencies.Add(new ProfConstitutionSave("Class Monk"));
            ProficiencyManager.Proficiencies.Add(new ProfIntelligenceSave("Class Monk"));
            ProficiencyManager.Proficiencies.Add(new ProfWisdomSave("Class Monk"));
            ProficiencyManager.Proficiencies.Add(new ProfCharismaSave("Class Monk"));
        }

        public override IFeature GetInstance() => new FMonkDiamondSoul(true);
    }
}
