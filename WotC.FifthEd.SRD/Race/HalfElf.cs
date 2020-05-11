using FifthCharacter.Plugin;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Race.HalfElf;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace WotC.FifthEd.SRD.Race {
    public class HalfElf : IRace {
        private const string SOURCE_TEXT = "Race Half-Elf";
        public virtual string Name => "Half-Elf";
        public string ID => "SRD.Race.HalfElf";
        public bool HasChoices => true;
        private PluginLoader PluginLoader;

        public HalfElf() { }

        protected HalfElf(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FHalfElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHalfElfDarkvision());
            FeaturesManager.Features.Add(new FHalfElfFeyAncestry());
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangElvish(SOURCE_TEXT));
            PluginLoader = PluginLoader.GetLoader();
            LanguageChoices = new List<IProficiency>(PluginLoader.Proficiencies.GetAllForType(ProficiencyType.LANGUAGE));
            LanguageChoices.RemoveAll(l => l.GetType() == typeof(ProfLangCommon) || l.GetType() == typeof(ProfLangElvish));
            SkillChoices = new List<IProficiency>(PluginLoader.Proficiencies.GetAllForType(ProficiencyType.SKILL));
            SkillChoices.RemoveAll(s => ProficiencyManager.CheckByName(s.Name));
        }

        public IRace GetInstance() => new HalfElf(true);

        public void BuildPopup(PopupNCRaceOptions raceOptions) {
            //TODO: add verification that skills 1 and 2 aren't the same
            Picker choice1 = new Picker() {
                Title = "Skill Varsatility",
                ItemsSource = SkillChoices,
                SelectedItem = SelectedSkill1,
                ItemDisplayBinding = new Binding("Name")
            };
            Picker choice2 = new Picker() {
                Title = "Skill Versatility",
                ItemsSource = SkillChoices,
                SelectedItem = SelectedSkill2,
                ItemDisplayBinding = new Binding("Name")
            };
            Picker choice3 = new Picker() {
                Title = "Extra Language",
                ItemsSource = LanguageChoices,
                SelectedItem = SelectedLanguage,
                ItemDisplayBinding = new Binding("Name")
            };
            StackLayout stackLayout = new StackLayout() {
                Orientation = StackOrientation.Vertical
            };
            stackLayout.Children.Add(choice1);
            stackLayout.Children.Add(choice2);
            stackLayout.Children.Add(choice3);
            stackLayout.Row(0);
            stackLayout.Column(0);
            stackLayout.ColumnSpan(2);
            raceOptions.Body.Children.Add(stackLayout);
        }

        public void ConfirmPopup() {
            SelectedSkill1.Source = SOURCE_TEXT;
            SelectedSkill2.Source = SOURCE_TEXT;
            SelectedLanguage.Source = SOURCE_TEXT;
            ProficiencyManager.Proficiencies.Add(SelectedSkill1);
            ProficiencyManager.Proficiencies.Add(SelectedSkill2);
            ProficiencyManager.Proficiencies.Add(SelectedLanguage);
        }

        //Popup Stuff
        public List<IProficiency> SkillChoices;
        public IProficiency SelectedSkill1;
        public IProficiency SelectedSkill2;
        public List<IProficiency> LanguageChoices;
        public IProficiency SelectedLanguage;
    }
}
