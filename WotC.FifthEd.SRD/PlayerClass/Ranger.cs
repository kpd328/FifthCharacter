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
using WotC.FifthEd.SRD.Features.PlayerClass.Ranger;
using Xamarin.Forms;

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
            { 1, new FRangerFavoredEnemy() },
            { 1, new FRangerNaturalExplorer() },
            { 2, new FRangerFightingStyle() },
            { 2, new FRangerSpellcasting() },
            { 3, new FRangerPrimevalAwareness() },
            { 4, new FRangerAbilityScoreImprovement() },
            { 5, new FRangerExtraAttack() },
            { 8, new FRangerAbilityScoreImprovement() },
            { 8, new FRangerLandsStride() },
            { 10, new FRangerHideInPlainSight() },
            { 12, new FRangerAbilityScoreImprovement() },
            { 14, new FRangerVanish() },
            { 16, new FRangerAbilityScoreImprovement() },
            { 18, new FRangerFeralSenses() },
            { 19, new FRangerAbilityScoreImprovement() },
            { 20, new FRangerFoeSlayer() }
        };
        private IList<FRangerRangerArchetype> RangerArchetypes;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.SECONDARY;

        internal Ranger() { }

        private Ranger(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            RangerArchetypes = new List<FRangerRangerArchetype>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FRangerRangerArchetype))).Cast<FRangerRangerArchetype>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfStrengthSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                //TODO: prompt to pick skills
            }
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
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
