using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Cleric;
using Xamarin.Forms;

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
            { 1, new FClericSpellcasting() },
            { 2, new FClericChannelDivinity() },
            { 4, new FClericAbilityScoreImprovement() },
            { 5, new FClericDestroyUndead() },
            { 8, new FClericAbilityScoreImprovement() },
            { 10, new FClericDivineIntervention() },
            { 12, new FClericAbilityScoreImprovement() },
            { 16, new FClericAbilityScoreImprovement() },
            { 19, new FClericAbilityScoreImprovement() }
        };
        private IList<FClericDivineDomain> DivineDomains;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.PRIMARY;

        internal Cleric() { }

        private Cleric(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            DivineDomains = new List<FClericDivineDomain>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FClericDivineDomain))).Cast<FClericDivineDomain>());
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
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
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
