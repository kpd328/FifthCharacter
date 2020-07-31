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

        public IList<IProficiency> ChosenInstruments { get; set; } = new List<IProficiency>();
        private int SelectedInstrCount = 0;
        private const int TOTAL_INSTRUMENTS = 3;
        private SfChipGroup SkillChoices;
        public IList<IProficiency> ChosenSkills { get; set; } = new List<IProficiency>();
        private int SelectedSkillCount = 0;
        private const int TOTAL_SKILLS = 3;
        private SfChipGroup InstrumentChoices;
        public void BuildNewCharacterPopup(Frame frame) {
            List<IProficiency> choices_instrprof = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.TOOL)
                .Where(p => p.ID.StartsWith("SRD.Proficiency.Tool.MusicalInstrument.")).ToList();
            for(int i = 0; i < choices_instrprof.Count; i++) {
                if (ProficiencyManager.CheckByName(choices_instrprof[i].Name)) {
                    choices_instrprof.RemoveAt(i);
                    i--;
                }
            }

            List<IProficiency> choices_skillprof = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.SKILL).ToList();
            for(int i = 0; i < choices_skillprof.Count; i++) {
                if (ProficiencyManager.CheckByName(choices_skillprof[i].Name)) {
                    choices_skillprof.RemoveAt(i);
                    i--;
                }
            }

            var instrTitle = new Label() {
                Text = "Choose 3 Musical Instrument Proficiencies",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Start
                //TODO: format
            };

            InstrumentChoices = new SfChipGroup() {
                Type = SfChipsType.Filter,
                ItemsSource = choices_instrprof,
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
            InstrumentChoices.SelectionChanging += InstrumentChoices_SelectionChanging;

            var skillTitle = new Label() {
                Text = "Choose 3 Skill Proficiencies",
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

            //TODO: add equipment choices: a Rapier, Longsword, or a Simple Weapon; a Diplomat's Pack or an Entertainer's Pack; a Musical Instrument
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(instrTitle);
            stackLayout.Children.Add(InstrumentChoices);
            stackLayout.Children.Add(skillTitle);
            stackLayout.Children.Add(SkillChoices);
            frame.Content = stackLayout;
        }

        private void InstrumentChoices_SelectionChanging(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangingEventArgs e) {
            if (SelectedInstrCount >= TOTAL_INSTRUMENTS) {
                e.Cancel = true;
            }
            if (e.AddedItem != null && !e.Cancel) {
                ChosenSkills.Add(e.AddedItem as IProficiency);
                SelectedInstrCount++;
            }
            if (e.RemovedItem != null) {
                ChosenSkills.Remove(e.RemovedItem as IProficiency);
                SelectedInstrCount--;

            }
            if (SelectedInstrCount >= TOTAL_INSTRUMENTS) {
                foreach (var c in InstrumentChoices.GetChips()) {
                    if (!c.IsChecked) {
                        c.IsCheckable = false;
                    }
                }
            }
            if (SelectedInstrCount < TOTAL_INSTRUMENTS) {
                foreach (var c in InstrumentChoices.GetChips()) {
                    c.IsCheckable = true;
                }
            }
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
            foreach (var s in ChosenInstruments) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
            foreach (var s in ChosenSkills) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
        }
    }
}
