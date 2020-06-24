using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Wizard;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Wizard : IPlayerClass {
        private const int SUBCLASS_LEVEL = 2;
        private const string SOURCE_TEXT = "Class Wizard";
        public string Name => "Wizard";
        public string ID => "SRD.PlayerClass.Wizard";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 6);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FWizardSpellcasting() },
            { 1, new FWizardArcaneRecovery() },
            { 4, new FWizardAbilityScoreImprovement() },
            { 8, new FWizardAbilityScoreImprovement() },
            { 12, new FWizardAbilityScoreImprovement() },
            { 16, new FWizardAbilityScoreImprovement() },
            { 18, new FWizardSpellMastery() },
            { 19, new FWizardAbilityScoreImprovement() },
            { 20, new FWizardSignatureSpells() }

        };
        private IList<FWizardArcaneTradition> ArcaneTraditions;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.PRIMARY;

        internal Wizard() { }

        private Wizard(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            ArcaneTraditions = new List<FWizardArcaneTradition>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FWizardArcaneTradition))).Cast<FWizardArcaneTradition>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfIntelligenceSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWDagger(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWDart(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWSling(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWQuarterstaff(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWLightCrossbow(SOURCE_TEXT));
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

        public IPlayerClass TakeAsPrimaryClass() => new Wizard(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Wizard(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
