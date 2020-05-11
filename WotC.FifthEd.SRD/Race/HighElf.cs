using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Race.Elf.High;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

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
            LanguageChoices = new List<IProficiency>(PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE));
            LanguageChoices.RemoveAll(l => l.GetType() == typeof(ProfLangCommon) || l.GetType() == typeof(ProfLangElvish));
        }

        public override IRace GetInstance() => new HighElf();

        public override void BuildPopup(PopupNCRaceOptions raceOptions) {
            Picker lang = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                SelectedItem = SelectedLanguage,
                ItemDisplayBinding = new Binding("Name")
            };
            lang.Row(0);
            lang.Column(0);
            lang.ColumnSpan(2);
            raceOptions.Body.Children.Add(lang);
        }

        public override void ConfirmPopup() {
            SelectedLanguage.Source = SOURCE_TEXT;
            ProficiencyManager.Proficiencies.Add(SelectedLanguage);
        }

        //Popup stuff
        public List<IProficiency> LanguageChoices;
        public IProficiency SelectedLanguage;
    }
}
