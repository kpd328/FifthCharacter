using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Race.Dwarf;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace WotC.FifthEd.SRD.Race {
    public abstract class ADwarf : IRace {
        private const string SOURCE_TEXT = "Race Dwarf";

        public virtual string Name => "Dwarf";
        public abstract string ID { get; }
        public bool HasChoices => true;

        protected ADwarf() {
            CharacterManager.Speed = 25;
            ProficiencyManager.Proficiencies.Add(new ProfMMWBattleaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWHandaxe(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSMWLightHammer(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMMWWarhammer(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangDwarvish(SOURCE_TEXT));
            FeaturesManager.Features.Add(new FDwarfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FDwarfDarkvision());
            FeaturesManager.Features.Add(new FDwarfDwarvenResilience());
            FeaturesManager.Features.Add(new FDwarfStonecunning());
        }

        public abstract IRace GetInstance();

        public virtual void BuildPopup(PopupNCRaceOptions raceOptions) {
            Picker tool = new Picker() {
                Title = "Tool Proficiency",
                ItemsSource = ToolChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            tool.SetBinding(Picker.SelectedItemProperty, "ChosenTool");
            tool.Row(0);
            tool.Column(0);
            tool.ColumnSpan(2);
            raceOptions.Body.Children.Add(tool);
        }
        
        public virtual void BuildPopup(PopupNCRaceOptions_GTK raceOptions) {
            Picker tool = new Picker() {
                Title = "Tool Proficiency",
                ItemsSource = ToolChoices,
                BindingContext = this,
                ItemDisplayBinding = new Binding("Name")
            };
            tool.SetBinding(Picker.SelectedItemProperty, "ChosenTool");
            tool.Row(0);
            tool.Column(0);
            tool.ColumnSpan(2);
            raceOptions.Body.Children.Add(tool);
        }

        public virtual void ConfirmPopup() {
            ProficiencyManager.Proficiencies.Add(ChosenTool);
        }

        //Popup stuff
        public List<IProficiency> ToolChoices = new List<IProficiency>() {
            new ProfSmithsTools(SOURCE_TEXT),
            new ProfBrewersSupplies(SOURCE_TEXT),
            new ProfMasonsTools(SOURCE_TEXT)
        };
        public IProficiency ChosenTool { get; set; }
    }
}
