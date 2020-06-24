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
using WotC.FifthEd.SRD.Features.PlayerClass.Rogue;
using WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Tools;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Rogue : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Rogue";
        public string Name => "Rogue";
        public string ID => "SRD.PlayerClass.Rogue";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FRogueExpertise() },
            { 1, new FRogueSneakAttack() },
            { 1, new FRogueThievesCant() },
            { 2, new FRogueCunningAction() },
            { 3, new FRogueAbilityScoreImprovement() },
            { 5, new FRogueUncannyDodge() },
            { 6, new FRogueExpertise() },
            { 7, new FRogueEvasion() },
            { 8, new FRogueAbilityScoreImprovement() },
            { 10, new FRogueAbilityScoreImprovement() },
            { 11, new FRogueReliableTalent() },
            { 12, new FRogueAbilityScoreImprovement() },
            { 14, new FRogueBlindsense() },
            { 15, new FRogueSlipperyMind() },
            { 16, new FRogueAbilityScoreImprovement() },
            { 18, new FRogueElusive() },
            { 19, new FRogueAbilityScoreImprovement() },
            { 20, new FRogueStrokeOfLuck() }
        };
        private IList<FRogueRoguishArchetype> RoguishArchetypes;
        private PluginLoader PluginLoader;
        private SpellcasterClass _CurrentSpellcasterClass = SpellcasterClass.NONE;
        public SpellcasterClass SpellcasterClass => _CurrentSpellcasterClass;

        internal Rogue() { }

        private Rogue(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            RoguishArchetypes = new List<FRogueRoguishArchetype>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FRogueRoguishArchetype))).Cast<FRogueRoguishArchetype>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfDexteritySave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfIntelligenceSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMRWHandCrossbow(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWLongsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWRapier(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfThievesTools(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfThievesTools(SOURCE_TEXT));
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

        public IPlayerClass TakeAsPrimaryClass() => new Rogue(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Rogue(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
