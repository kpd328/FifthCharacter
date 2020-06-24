using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Druid;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using Xamarin.Forms;

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
            { 1, new FDruidDruidic() },
            { 1, new FDruidSpellcasting() },
            { 2, new FDruidWildShape() },
            { 4, new FDruidAbilityScoreIncrease() },
            { 8, new FDruidAbilityScoreIncrease() },
            { 12, new FDruidAbilityScoreIncrease() },
            { 16, new FDruidAbilityScoreIncrease() },
            { 18, new FDruidTimelessBody() },
            { 18, new FDruidBeastSpells() },
            { 19, new FDruidAbilityScoreIncrease() },
            { 20, new FDruidArchdruid() }
        };
        private IList<FDruidDruidCircle> DruidCircles;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.PRIMARY;

        internal Druid() { }

        private Druid(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            DruidCircles = new List<FDruidDruidCircle>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FDruidDruidCircle))).Cast<FDruidDruidCircle>());
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
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
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
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(Level, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
            }
        }

        private void SelectSubclass() {
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }

        public void BuildNewCharacterPopup(Frame frame) {

        }

        public void ConfirmNewCharacterPopup() {

        }
    }
}
