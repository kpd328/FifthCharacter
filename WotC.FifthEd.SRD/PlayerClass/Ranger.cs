using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Ranger : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Ranger";
        public string Name => "Ranger";
        public string ID => "SRD.PlayerClass.Ranger";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 10);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {

        };

        internal Ranger() { }

        private Ranger(bool isPrimary) : base() {
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfStrengthSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMRWHandCrossbows(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMRWHandCrossbows(SOURCE_TEXT));
                //TODO: prompt to pick skills
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Ranger(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Ranger(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

        public void LevelUp() {
            Level++;
            CurrentTotalHitDice.Number++;
            if (Level == SUBCLASS_LEVEL) {
                SelectSubclass();
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach (IFeature f in newFeatures) {
                ClassFeatures.Add(f);
            }
        }

        private void SelectSubclass() {
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }
    }
}
