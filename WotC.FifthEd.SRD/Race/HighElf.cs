using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using Syncfusion.XForms.Buttons;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.Race.Elf.High;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Race {
    public class HighElf : AElf {
        private const string SOURCE_TEXT = "Race Elf (High)";
        public override string Name => "High Elf";
        public override string ID => "SRD.Race.Elf.High";
        public override bool HasChoices => true;
        private PluginLoader PluginLoader;

        public HighElf() { }

        protected HighElf(bool isRace) : base() {
            FeaturesManager.Features.Add(new FHighElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHighElfCantrip());
            ProficiencyManager.Proficiencies.Add(new ProfMMWLongsword(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSRWShortbow(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMRWLongbow(SOURCE_TEXT));
            PluginLoader = PluginLoader.GetLoader();
        }

        public override IRace GetInstance() => new HighElf(true);


        private IList<IProficiency> ChosenLanguages { get; set; } = new List<IProficiency>();
        private int SelectedCount = 0;
        private const int TOTAL_LANG = 1;
        private SfChipGroup LanguageChoices;
        public override void BuildPopup(PopupNCRaceOptions raceOptions) {
            List<IProficiency> choices = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE)
                .Where(p => p.ID != "SRD.Proficiency.Language.Common"
                && p.ID != "SRD.Proficiency.Language.Elvish").ToList();
            for (int i = 0; i < choices.Count; i++) {
                if (ProficiencyManager.CheckByName(choices[i].Name)) {
                    choices.RemoveAt(i);
                    i--;
                }
            }

            var langTitle = new Label() {
                Text = "Choose an extra Language",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Start
                //TODO: format
            };

            LanguageChoices = new SfChipGroup() {
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
            LanguageChoices.SelectionChanging += LanguageChoices_SelectionChanging;

            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(langTitle);
            stackLayout.Children.Add(LanguageChoices);
            raceOptions.Body.Children.Add(stackLayout);
        }

        private void LanguageChoices_SelectionChanging(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangingEventArgs e) {
            if (SelectedCount >= TOTAL_LANG) {
                e.Cancel = true;
            }
            if (e.AddedItem != null && !e.Cancel) {
                ChosenLanguages.Add(e.AddedItem as IProficiency);
                SelectedCount++;
            }
            if (e.RemovedItem != null) {
                ChosenLanguages.Remove(e.RemovedItem as IProficiency);
                SelectedCount--;

            }
            if (SelectedCount >= TOTAL_LANG) {
                foreach (var c in LanguageChoices.GetChips()) {
                    if (!c.IsChecked) {
                        c.IsCheckable = false;
                    }
                }
            }
            if (SelectedCount < TOTAL_LANG) {
                foreach (var c in LanguageChoices.GetChips()) {
                    c.IsCheckable = true;
                }
            }
        }

        public override void ConfirmPopup() {
            foreach (var s in ChosenLanguages) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
        }
    }
}
