using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using SD.Tools.Algorithmia.GeneralDataStructures;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Druid : IPlayerClass {
        private const int SUBCLASS_LEVEL = 2;
        private const string SOURCE_TEXT = "Class Druid";
        public string Name => "Druid";
        public string ID => "SRD.PlayerClass.Druid";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {

        };

        internal Druid() { }

        private Druid(bool isPrimary) : base() {
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfIntelligenceSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWClub(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWDagger(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWDart(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWJavelin(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWMace(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWQuarterstaff(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWScimitar(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWSickle(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWSling(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWSpear(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: add herbalism kit tools
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

        public IPlayerClass TakeAsPrimaryClass() => new Druid(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Druid(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
