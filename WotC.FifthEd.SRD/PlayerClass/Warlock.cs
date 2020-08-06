using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.Attacks;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using Syncfusion.XForms.Buttons;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Warlock;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Warlock : IPlayerClass {
        private const int SUBCLASS_LEVEL = 1;
        private const string SOURCE_TEXT = "Class Warlock";
        public string Name => "Warlock";
        public string ID => "SRD.PlayerClass.Warlock";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FWarlockPactMagic() },
            { 2, new FWarlockEldritchInvocations() },
            { 3, new FWarlockPactBoon() },
            { 4, new FWarlockAbilityScoreImprovement() },
            { 8, new FWarlockAbilityScoreImprovement() },
            { 11, new FWarlockMysticArcanum() },
            { 12, new FWarlockAbilityScoreImprovement() },
            { 16, new FWarlockAbilityScoreImprovement() },
            { 19, new FWarlockAbilityScoreImprovement() },
            { 20, new FWarlockEldritchMaster() }
        };
        private IList<FWarlockOtherworldlyPatron> OtherworldlyPatrons;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.NONE;

        internal Warlock() { }

        private Warlock(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            OtherworldlyPatrons = new List<FWarlockOtherworldlyPatron>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FWarlockOtherworldlyPatron))).Cast<FWarlockOtherworldlyPatron>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfCharismaSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                //TODO: prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
            }
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if (AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Warlock(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Warlock(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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

        public IList<IProficiency> ChosenSkills { get; set; } = new List<IProficiency>();
        private int SelectedSkillCount = 0;
        private const int TOTAL_SKILLS = 2;
        private SfChipGroup SkillChoices;
        public void BuildNewCharacterPopup(Frame frame) {
            List<IProficiency> choices = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.SKILL)
                .Where(p => p.Name == "Arcana" || p.Name == "Deception" || p.Name == "History"
                || p.Name == "Intimidation" || p.Name == "Investigation" || p.Name == "Nature" 
                || p.Name == "Religion").ToList();
            for (int i = 0; i < choices.Count; i++) {
                if (ProficiencyManager.CheckByName(choices[i].Name)) {
                    choices.RemoveAt(i);
                    i--;
                }
            }

            var Title = new Label() {
                Text = "Choose 2 Skill Proficiencies",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Start
                //TODO: format
            };

            SkillChoices = new SfChipGroup() {
                Type = SfChipsType.Filter,
                ItemsSource = choices,
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

            //TODO: add equipment choices: a Light Crossbow w/ 20 Bolts or any Simple Weapon; a Component Pouch or an Arcane Focus; a Scolar's Pack or a Dungeoneer's Pack
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(Title);
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
            foreach (var s in ChosenSkills) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
        }
    }
}
