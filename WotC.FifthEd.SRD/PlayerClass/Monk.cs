using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Monk;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Monk : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Monk";
        public string Name => "Monk";
        public string ID => "SRD.PlayerClass.Monk";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FMonkUnarmoredDefense() },
            { 1, new FMonkMartialArts() },
            { 2, new FMonkKi() },
            { 2, new FMonkUnarmoredMovement() },
            { 3, new FMonkDeflectMissiles() },
            { 4, new FMonkAbilityScoreImprovement() },
            { 4, new FMonkSlowFall() },
            { 5, new FMonkExtraAttack() },
            { 5, new FMonkStunningStrike() },
            { 6, new FMonkKiEmpoweredStrikes() },
            { 7, new FMonkEvasion() },
            { 7, new FMonkStillnessOfMind() },
            { 8, new FMonkAbilityScoreImprovement() },
            { 10, new FMonkPurityOfBody() },
            { 12, new FMonkAbilityScoreImprovement() },
            { 13, new FMonkTongueOfTheSunAndMoon() },
            { 14, new FMonkDiamondSoul() },
            { 15, new FMonkTimelessBody() },
            { 16, new FMonkAbilityScoreImprovement() },
            { 18, new FMonkEmptyBody() },
            { 19, new FMonkAbilityScoreImprovement() },
            { 20, new FMonkPerfectSelf() }
        };
        private IList<FMonkMonasticTradition> MonasticTraditions;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.NONE;

        internal Monk() { }

        private Monk(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            MonasticTraditions = new List<FMonkMonasticTradition>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FMonkMonasticTradition))).Cast<FMonkMonasticTradition>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfStrengthSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
            }
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Monk(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Monk(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
