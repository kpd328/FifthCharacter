using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using Syncfusion.XForms.Buttons;
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

        public IProficiency ChosenTool { get; set; }
        public IList<IProficiency> ChosenSkills { get; set; } = new List<IProficiency>();
        private int SelectedSkillCount = 0;
        private const int TOTAL_SKILLS = 2;
        private SfChipGroup SkillChoices;
        public void BuildNewCharacterPopup(Frame frame) {
            List<IProficiency> choices_toolprof = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.TOOL)
                .Where(p => p.ID.StartsWith("SRD.Proficiency.Tool.MusicalInstrument.") 
                || p.ID.StartsWith("SRD.Proficiency.Tool.ArtisansTools.")).ToList();
            for(int i = 0; i < choices_toolprof.Count; i++) {
                if (ProficiencyManager.CheckByName(choices_toolprof[i].Name)) {
                    choices_toolprof.RemoveAt(i);
                    i--;
                }
            }

            List<IProficiency> choices_skillprof = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.SKILL)
                .Where(p => p.Name == "Acrobatics" || p.Name == "Athletics" || p.Name == "History" || p.Name == "Insight"
                || p.Name == "Religion" || p.Name == "Stealth").ToList();
            for(int i = 0; i < choices_skillprof.Count; i++) {
                if (ProficiencyManager.CheckByName(choices_skillprof[i].Name)) {
                    choices_skillprof.RemoveAt(i);
                    i--;
                }
            }

            var ToolTitle = new Label() {
                Text = "Choose an Artisan's Tool or Instrument Proficiency",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start,
                LineBreakMode = Xamarin.Forms.LineBreakMode.WordWrap
                //TODO: format
            };

            var ToolChoice = new Picker() {
                ItemsSource = choices_toolprof,
                ItemDisplayBinding = new Binding("Name"),
                BindingContext = this,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
            ToolChoice.SetBinding(Picker.SelectedItemProperty, "ChosenTool");

            var SkillTitle = new Label() {
                Text = "Choose 2 Skill Proficiencies",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Start
                //TODO: format
            };

            SkillChoices = new SfChipGroup() {
                Type = SfChipsType.Filter,
                ItemsSource = choices_skillprof,
                DisplayMemberPath = "Name",
                ChipLayout = new FlexLayout() {
                    Direction = FlexDirection.Row,
                    Wrap = FlexWrap.Wrap,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    AlignContent = FlexAlignContent.SpaceEvenly,
                    JustifyContent = FlexJustify.Start,
                    AlignItems = FlexAlignItems.Start
                }
            };
            SkillChoices.SelectionChanging += SkillChoices_SelectionChanging;

            //TODO: add equipment choices: a Shortsword or any Simple Weapon; a Dungeoneer's Pack or an Explorer's Pack
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(ToolTitle);
            stackLayout.Children.Add(ToolChoice);
            stackLayout.Children.Add(SkillTitle);
            stackLayout.Children.Add(SkillChoices);
            frame.Content = stackLayout;
        }

        private void SkillChoices_SelectionChanging(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangingEventArgs e) {
            if (SelectedSkillCount >= TOTAL_SKILLS) {
                e.Cancel = true;
            }
            if (e.AddedItem != null && !e.Cancel) {
                ChosenSkills.Add(e.AddedItem as IProficiency);
                SelectedSkillCount++;
            }
            if (e.RemovedItem != null) {
                ChosenSkills.Remove(e.RemovedItem as IProficiency);
                SelectedSkillCount--;

            }
            if (SelectedSkillCount >= TOTAL_SKILLS) {
                foreach (var c in SkillChoices.GetChips()) {
                    if (!c.IsChecked) {
                        c.IsCheckable = false;
                    }
                }
            }
            if (SelectedSkillCount < TOTAL_SKILLS) {
                foreach (var c in SkillChoices.GetChips()) {
                    c.IsCheckable = true;
                }
            }
        }

        public void ConfirmNewCharacterPopup() {
            ChosenTool.Source = SOURCE_TEXT;
            ProficiencyManager.Proficiencies.Add(ChosenTool);
            foreach (var s in ChosenSkills) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
        }
    }
}
