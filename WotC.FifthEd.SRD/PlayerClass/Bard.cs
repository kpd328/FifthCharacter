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
using WotC.FifthEd.SRD.Features.PlayerClass.Bard;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Bard : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Bard";
        public string Name => "Bard";
        public string ID => "SRD.PlayerClass.Bard";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FBardSpellcasting() },
            { 1, new FBardBardicInspiration() },
            { 2, new FBardJackOfAllTrades() },
            { 2, new FBardSongOfRest() },
            { 3, new FBardExpertise() },
            { 4, new FBardAbilityScoreImprovement() },
            { 5, new FBardFontOfInspiration() },
            { 6, new FBardCountercharm() },
            { 8, new FBardAbilityScoreImprovement() },
            { 10, new FBardExpertise() },
            { 10, new FBardMagicalSecrets() },
            { 12, new FBardAbilityScoreImprovement() },
            { 14, new FBardSongOfRest() },
            { 16, new FBardAbilityScoreImprovement() },
            { 18, new FBardMagicalSecrets() },
            { 19, new FBardAbilityScoreImprovement() },
            { 20, new FBardSuperiorInspiration() }
        };
        private IList<FBardBardCollege> BardColleges;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.PRIMARY;

        internal Bard() { }

        private Bard(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            BardColleges = new List<FBardBardCollege>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FBardBardCollege))).Cast<FBardBardCollege>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMRWHandCrossbow(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWLongsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWRapier(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
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

        public IPlayerClass TakeAsPrimaryClass() => new Bard(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Bard(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
