using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Armor;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using Microsoft.Collections.Extensions;
using Syncfusion.XForms.Buttons;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.PlayerClass.Druid;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Druid : IPlayerClass {
        private const int SUBCLASS_LEVEL = 2;
        private const string SOURCE_TEXT = "Class Druid";
        public string Name => "Druid";
        public string ID => "SRD.PlayerClass.Druid";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 8);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FDruidDruidic() },
            { 1, new FDruidSpellcasting() },
            { 2, new FDruidWildShape() },
            { 4, new FDruidAbilityScoreIncrease() },
            { 8, new FDruidAbilityScoreIncrease() },
            { 12, new FDruidAbilityScoreIncrease() },
            { 16, new FDruidAbilityScoreIncrease() },
            { 18, new FDruidTimelessBody() },
            { 18, new FDruidBeastSpells() },
            { 19, new FDruidAbilityScoreIncrease() },
            { 20, new FDruidArchdruid() }
        };
        private IList<FDruidDruidCircle> DruidCircles;
        private PluginLoader PluginLoader;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.PRIMARY;

        internal Druid() { }

        private Druid(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            DruidCircles = new List<FDruidDruidCircle>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FDruidDruidCircle))).Cast<FDruidDruidCircle>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfIntelligenceSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfWisdomSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWClub(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWDagger(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWDart(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWJavelin(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWMace(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWQuarterstaff(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMMWScimitar(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWSickle(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSRWSling(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSMWSpear(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: add herbalism kit tools
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

        public IPlayerClass TakeAsPrimaryClass() => new Druid(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Druid(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
                .Where(p => p.Name == "Arcana" || p.Name == "Animal Handling" || p.Name == "Insight"
                || p.Name == "Medicine" || p.Name == "Nature" || p.Name == "Perception" || p.Name == "Religion"
                || p.Name == "Survival").ToList();
            for(int i = 0; i < choices.Count; i++) {
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

            //TODO: add equipment choices: a Wooden Shield or any Simple Weapon; a Scimitar or any Simple Melee Weapon
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
