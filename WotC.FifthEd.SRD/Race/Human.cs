using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using System.Collections.Generic;
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
            LanguageChoices = new List<IProficiency>(PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE));
            LanguageChoices.RemoveAll(l => l.GetType() == typeof(ProfLangCommon) || l.GetType() == typeof(ProfLangElvish));
        }

        public IRace GetInstance() => new Human(true);

        public void BuildPopup(PopupNCRaceOptions raceOptions) {
            Picker lang = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage");
            lang.Row(0);
            lang.Column(0);
            lang.ColumnSpan(2);
            raceOptions.Body.Children.Add(lang);
        }

        public void BuildPopup(PopupNCRaceOptions_GTK raceOptions) {
            Picker lang = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage");
            lang.Row(0);
            lang.Column(0);
            lang.ColumnSpan(2);
            raceOptions.Body.Children.Add(lang);
        }

        public void ConfirmPopup() {
            SelectedLanguage.Source = SOURCE_TEXT;
            ProficiencyManager.Proficiencies.Add(SelectedLanguage);
        }

        //Popup stuff
        public List<IProficiency> LanguageChoices;
        public IProficiency SelectedLanguage;
    }
}
