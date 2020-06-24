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
using WotC.FifthEd.SRD.Features.PlayerClass.Paladin;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Paladin : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Paladin";
        public string Name => "Paladin";
        public string ID => "SRD.PlayerClass.Paladin";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 10);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FPaladinDivineSense() },
            { 1, new FPaladinLayOnHands() },
            { 2, new FPaladinFightingStyle() },
            { 2, new FPaladinSpellcasting() },
            { 2, new FPaladinDivineSmite() },
            { 3, new FPaladinDivineHealth() },
            { 4, new FPaladinAbilityScoreImprovement() },
            { 5, new FPaladinExtraAttack() },
            { 6, new FPaladinAuraOfProtection() },
            { 8, new FPaladinAbilityScoreImprovement() },
            { 10, new FPaladinAuraOfCourage() },
            { 11, new FPaladinImprovedDivineSmite() },
            { 12, new FPaladinAbilityScoreImprovement() },
            { 14, new FPaladinCleansingTouch() },
            { 16, new FPaladinAbilityScoreImprovement() },
            { 19, new FPaladinAbilityScoreImprovement() }
        };
        private IList<FPaladinSacredOath> SacredOaths;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.SECONDARY;

        internal Paladin() { }

        private Paladin(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            SacredOaths = new List<FPaladinSacredOath>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FPaladinSacredOath))).Cast<FPaladinSacredOath>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmor(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
            }
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Paladin(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Paladin(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
