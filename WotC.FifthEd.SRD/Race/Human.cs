using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using Syncfusion.XForms.Buttons;
using System.Collections.Generic;
using System.Linq;
using WotC.FifthEd.SRD.Features.Race.Human;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace WotC.FifthEd.SRD.Race {
    public class Human : IRace {
        private const string SOURCE_TEXT = "Race Human";
        public string Name => "Human";
        public string ID => "SRD.Race.Human";
        public bool HasChoices => true;
        private PluginLoader PluginLoader;

        public Human() { }

        protected Human(bool isRace) {
            FeaturesManager.Features.Add(new FHumanAbilityScoreIncrease());
            CharacterManager.Speed = 30;
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            PluginLoader = PluginLoader.GetLoader();
        }

        public IRace GetInstance() => new Human(true);

        public IList<IProficiency> ChosenLanguages { get; set; } = new List<IProficiency>();
        private int SelectedCount = 0;
        private const int TOTAL_LANG = 1;
        private SfChipGroup LanguageChoices;
        public void BuildPopup(PopupNCRaceOptions raceOptions) {
            List<IProficiency> choices = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE)
                .Where(p => p.ID != "SRD.Proficiency.Language.Common").ToList();
            for(int i = 0; i < choices.Count; i++) {
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

        public void BuildPopup(PopupNCRaceOptions_GTK raceOptions) {
            List<IProficiency> choices = PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE)
                .Where(p => p.ID != "SRD.Proficiency.Language.Common").ToList();
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

        public void ConfirmPopup() {
            foreach(var s in ChosenLanguages) {
                s.Source = SOURCE_TEXT;
                ProficiencyManager.Proficiencies.Add(s);
            }
        }
    }
}
