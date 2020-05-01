using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Cleric : IPlayerClass {
        private const int SUBCLASS_LEVEL = 1;
        private const string SOURCE_TEXT = "Class Cleric";
        public string Name => "Cleric";
        public string ID => "SRD.PlayerClass.Cleric";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {

        };

        internal Cleric() { }

        private Cleric(bool isPrimary) : base() {
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach (IFeature f in newFeatures) {
                ClassFeatures.Add(f);
                FeaturesManager.Features.Add(f);
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Cleric(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Cleric(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

        public void LevelUp() {
            Level++;
            CurrentTotalHitDice.Number++;
            if (Level == SUBCLASS_LEVEL) {
                SelectSubclass();
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach (IFeature f in newFeatures) {
                ClassFeatures.Add(f);
                FeaturesManager.Features.Add(f);
            }
        }

        private void SelectSubclass() {
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }
    }
}
