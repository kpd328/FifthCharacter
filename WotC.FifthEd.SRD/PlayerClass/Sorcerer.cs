using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Sorcerer : IPlayerClass {
        private const int SUBCLASS_LEVEL = 1;
        private const string SOURCE_TEXT = "Class Sorcerer";
        public string Name => "Sorcerer";
        public string ID => "SRD.PlayerClass.Sorcerer";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 6);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {

        };

        internal Sorcerer() { }

        private Sorcerer(bool isPrimary) : base() {
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfConstitutionSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWDagger(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWDart(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWSling(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWQuarterstaff(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWLightCrossbow(SOURCE_TEXT));
                //TODO: prompt to pick skills
            }
            var newFeatures = AllClassFeatures.GetValues(Level, true);
            foreach (IFeature f in newFeatures) {
                ClassFeatures.Add(f);
                FeaturesManager.Features.Add(f);
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Sorcerer(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Sorcerer(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
