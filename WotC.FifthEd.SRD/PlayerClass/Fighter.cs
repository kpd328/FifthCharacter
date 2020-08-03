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
using WotC.FifthEd.SRD.Features.PlayerClass.Fighter;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.PlayerClass {
    public class Fighter : IPlayerClass {
        private const int SUBCLASS_LEVEL = 3;
        private const string SOURCE_TEXT = "Class Fighter";
        public string Name => "Fighter";
        public string ID => "SRD.PlayerClass.Figher";
        public int Level { get; private set; }
        public Dice HitDicePerLevel => new Dice(1, 10);
        public Dice CurrentTotalHitDice { get; private set; }
        public IList<IFeature> ClassFeatures => new List<IFeature>();
        private MultiValueDictionary<int, IFeature> AllClassFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FFighterFightingStyle() },
            { 1, new FFighterSecondWind() },
            { 2, new FFighterActionSurge() },
            { 4, new FFighterAbilityScoreImprovement() },
            { 5, new FFighterExtraAttack() },
            { 6, new FFighterAbilityScoreImprovement() },
            { 8, new FFighterAbilityScoreImprovement() },
            { 9, new FFighterIndomitable() },
            { 12, new FFighterAbilityScoreImprovement() },
            { 14, new FFighterAbilityScoreImprovement() },
            { 16, new FFighterAbilityScoreImprovement() },
            { 19, new FFighterAbilityScoreImprovement() }
        };
        private IList<FFighterMartialArchetype> MartialArchetypes;
        private PluginLoader PluginLoader;
        private SpellcasterClass _CurrentSpellcasterClass = SpellcasterClass.NONE;
        public SpellcasterClass SpellcasterClass => SpellcasterClass.NONE;

        internal Fighter() { }

        private Fighter(bool isPrimary) : base() {
            PluginLoader = PluginLoader.GetLoader();
            MartialArchetypes = new List<FFighterMartialArchetype>(PluginLoader.Subclasses.Where(f => f.GetType().IsSubclassOf(typeof(FFighterMartialArchetype))).Cast<FFighterMartialArchetype>());
            if (isPrimary) {
                ProficiencyManager.Proficiencies.Add(new ProfStrengthSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfConstitutionSave(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmor(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
                //TODO: Add prompt to pick skills
            } else {
                ProficiencyManager.Proficiencies.Add(new ProfSimpleWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfMartialWeapon(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorLight(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorMedium(SOURCE_TEXT));
                ProficiencyManager.Proficiencies.Add(new ProfArmorShield(SOURCE_TEXT));
            }
            //TODO: Add prompt to pick fighting style
            IReadOnlyCollection<IFeature> newFeatures = new List<IFeature>();
            if(AllClassFeatures.TryGetValue(1, out newFeatures)) {
                foreach (IFeature f in newFeatures) {
                    ClassFeatures.Add(f);
                    FeaturesManager.Features.Add(f);
                }
            }
        }

        public IPlayerClass TakeAsPrimaryClass() => new Fighter(true) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };
        public IPlayerClass TakeAsSecondaryClass() => new Fighter(false) { Level = 1, CurrentTotalHitDice = new Dice(HitDicePerLevel) };

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
            //Popup a prompt to select a subclass (or add prompt to levelup popup queue
        }

        public IList<IProficiency> ChosenSkills { get; set; } = new List<IProficiency>();
        private int SelectedSkillCount = 0;
        private const int TOTAL_SKILLS = 2;
        private SfChipGroup SkillChoices;
        public void BuildNewCharacterPopup(Frame frame) {
            List<IProficiency> choices = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.SKILL)
                .Where(p => p.Name == "Acrobatics" || p.Name == "Animal Handling" || p.Name == "Athletics" 
                || p.Name == "History" || p.Name == "Insight" || p.Name == "Intimidation" || p.Name == "Perception"
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

            //TODO: add equipment choices: Chain Mail or Leather Armor, a Longbow w/ 20 Arrows; a Martial Weapon and Shield or 2 Martial Weapons; a Light Crossbow w/ 20 Bolts or 2 Handaxes; a Dungeoneer's Pack or and Explorer's Pack
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
