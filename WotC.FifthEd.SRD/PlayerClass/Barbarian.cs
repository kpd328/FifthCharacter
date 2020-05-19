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
using WotC.FifthEd.SRD.Features.PlayerClass.Barbarian;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Barbarian : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Barbarian";
        public string Name => "Barbarian";
        public string ID => "SRD.PlayerClass.Barbarian";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 12);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FBarbarianRage() },
            { 1, new FBarbarianUnarmoredDefense() },
            { 2, new FBarbarianRecklessAttack() },
            { 2, new FBarbarianDangerSense() },
            { 4, new FBarbarianAbilityScoreImprovement() },
            { 5, new FBarbarianExtraAttack() },
            { 5, new FBarbarianFastMovement() },
            { 7, new FBarbarianFeralInstinct() },
            { 8, new FBarbarianAbilityScoreImprovement() },
            { 9, new FBarbarianBrutalCritical() },
            { 11, new FBarbarianRelentlessRage() },
            { 12, new FBarbarianAbilityScoreImprovement() },
            { 15, new FBarbarianPersistentRage() },
            { 16, new FBarbarianAbilityScoreImprovement() },
            { 18, new FBarbarianIndomitableMight() },
            { 19, new FBarbarianAbilityScoreImprovement() },
            { 20, new FBarbarianPrimalChampion() }
        };
        private IList<FBarbarianPrimalPath> PrimalPaths;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.NONE;

        internal Barbarian() { }

        private Barbarian(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            PrimalPaths = new List<FBarbarianPrimalPath>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FBarbarianPrimalPath))).Cast<FBarbarianPrimalPath>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfStrengthSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfConstitutionSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
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

        public IPlayerClass TakeAsPrimaryClass() => new Barbarian(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Barbarian(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

        public void LevelUp() {
            Level++;
            CurrentTotalHitDice.Number++;
            if(Level == SUBCLASS_LEVEL) {
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
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue)
        }
    }
}
