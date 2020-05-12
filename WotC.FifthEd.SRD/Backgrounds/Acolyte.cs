using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;
using System.Collections;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Background;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace WotC.FifthEd.SRD.Backgrounds {
    public class Acolyte : IBackground {
        private const string SOURCE_TEXT = "Background Acolyte";
        public string Name => "Acolyte";
        public string ID => "SRD.Background.Acolyte";
        public bool HasChoices => true;
        private PluginLoader PluginLoader;

        public Acolyte() { }

        protected Acolyte(bool isBackground) {
            ProficiencyManager.Proficiencies.Add(new ProfInsight(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfReligion(SOURCE_TEXT));
            FeaturesManager.Features.Add(new FAcolyteShelterOfTheFaithful());
            PluginLoader = PluginLoader.GetLoader();
            LanguageChoices = new List<IProficiency>(PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE));
            LanguageChoices.RemoveAll(l => ProficiencyManager.CheckByName(l.Name, ProficiencyType.LANGUAGE));
        }

        public IBackground GetInstance() => new Acolyte(true);

        public void BuildPopup(PopupNCBackgroundOptions backgroundOptions) {
            Picker lang1 = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang1.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage1");
            Picker lang2 = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang2.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage2");
            //TODO: equipment (plus prompt for options
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(lang1);
            stackLayout.Children.Add(lang2);
            stackLayout.Row(0);
            stackLayout.Column(0);
            stackLayout.ColumnSpan(2);
            backgroundOptions.Body.Children.Add(stackLayout);
        }

        public void BuildPopup(PopupNCBackgroundOptions_GTK backgroundOptions) {
            Picker lang1 = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang1.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage1");
            Picker lang2 = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            lang2.SetBinding(Picker.SelectedItemProperty, "SelectedLanguage2");
            //TODO: equipment (plus prompt for options
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(lang1);
            stackLayout.Children.Add(lang2);
            stackLayout.Row(0);
            stackLayout.Column(0);
            stackLayout.ColumnSpan(2);
            backgroundOptions.Body.Children.Add(stackLayout);
        }

        public void ConfirmPopup() {
            SelectedLanguage1.Source = SOURCE_TEXT;
            SelectedLanguage2.Source = SOURCE_TEXT;
            ProficiencyManager.Proficiencies.Add(SelectedLanguage1);
            ProficiencyManager.Proficiencies.Add(SelectedLanguage2);
            //TODO: confirm equipment
        }

        //Popup stuff
        public List<IProficiency> LanguageChoices;
        public IProficiency SelectedLanguage1 { get; set; }
        public IProficiency SelectedLanguage2 { get; set; }
    }
}
