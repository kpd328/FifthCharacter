using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Features.Race.Dragonborn;
using WotC.FifthEd.SRD.Proficiencies.Languages;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace WotC.FifthEd.SRD.Race {
    public class Dragonborn : IRace {
        private const string SOURCE_TEXT = "Race Dragonborn";
        public string Name => "Dragonborn";
        public string ID => "SRD.Race.Dragonborn";
        public DraconicAncestry Ancestry { get; private set; }
        public bool HasChoices => true;

        public Dragonborn() { }

        protected Dragonborn(bool isRace) {
            CharacterManager.Speed = 30;
            FeaturesManager.Features.Add(new FDragonbornAbilityScoreIncrease());
            ProficiencyManager.Proficiencies.Add(new ProfLangCommon(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfLangDraconic(SOURCE_TEXT));
        }

        public IRace GetInstance() => new Dragonborn(true);

        public void BuildPopup(PopupNCRaceOptions raceOptions) {
            Picker ancestry = new Picker() {
                ItemsSource = AncestryOptions,
                Title = "Draconic Ancestry",
                BindingContext = this
            };
            ancestry.SetBinding(Picker.SelectedItemProperty, "ChosenAncestry");
            ancestry.Row(0);
            ancestry.Column(0);
            ancestry.ColumnSpan(2);
            raceOptions.Body.Children.Add(ancestry);
        }
        public void BuildPopup(PopupNCRaceOptions_GTK raceOptions) {
            Picker ancestry = new Picker() {
                ItemsSource = AncestryOptions,
                Title = "Draconic Ancestry",
                BindingContext = this
            };
            ancestry.SetBinding(Picker.SelectedItemProperty, "ChosenAncestry");
            ancestry.Row(0);
            ancestry.Column(0);
            ancestry.ColumnSpan(2);
            raceOptions.Body.Children.Add(ancestry);
        }

        public void ConfirmPopup() {
            FeaturesManager.Features.Add(new FDragonbornBreathWeapon(Ancestry));
            FeaturesManager.Features.Add(new FDragonbornDamageResistance(Ancestry));
        }

        //Popup stuff
        public List<string> AncestryOptions = new List<string>() {
            DraconicAncestry.BLACK.DisplayString(),
            DraconicAncestry.BLUE.DisplayString(),
            DraconicAncestry.BRASS.DisplayString(),
            DraconicAncestry.BRONZE.DisplayString(),
            DraconicAncestry.COPPER.DisplayString(),
            DraconicAncestry.GOLD.DisplayString(),
            DraconicAncestry.GREEN.DisplayString(),
            DraconicAncestry.RED.DisplayString(),
            DraconicAncestry.SILVER.DisplayString(),
            DraconicAncestry.WHITE.DisplayString()
        };

        public string ChosenAncestry {
            get => Ancestry.DisplayString();
            set => Ancestry = value.ParseToDraconicAncestry();
        }
    }

    public enum DraconicAncestry {
        NONE,
        BLACK,
        BLUE,
        BRASS,
        BRONZE,
        COPPER,
        GOLD,
        GREEN,
        RED,
        SILVER,
        WHITE
    }

    public static class DraconicAncestryExtension {
        public static string DisplayString(this DraconicAncestry ancestry) => ancestry switch {
            DraconicAncestry.NONE => "",
            DraconicAncestry.BLACK => "Black",
            DraconicAncestry.BLUE => "Blue",
            DraconicAncestry.BRASS => "Brass",
            DraconicAncestry.BRONZE => "Bronze",
            DraconicAncestry.COPPER => "Copper",
            DraconicAncestry.GOLD => "Gold",
            DraconicAncestry.GREEN => "Green",
            DraconicAncestry.RED => "Red",
            DraconicAncestry.SILVER => "Silver",
            DraconicAncestry.WHITE => "White",
            _ => null
        };
        public static DraconicAncestry ParseToDraconicAncestry(this string stringancestry) => stringancestry switch {
            "Black" => DraconicAncestry.BLACK,
            "Blue" => DraconicAncestry.BLUE,
            "Brass" => DraconicAncestry.BRASS,
            "Bronze" => DraconicAncestry.BRONZE,
            "Copper" => DraconicAncestry.COPPER,
            "Gold" => DraconicAncestry.GOLD,
            "Green" => DraconicAncestry.GREEN,
            "Red" => DraconicAncestry.RED,
            "Silver" => DraconicAncestry.SILVER,
            "White" => DraconicAncestry.WHITE,
            null => DraconicAncestry.NONE,
            "" => DraconicAncestry.NONE,
            _ => throw new InvalidCastException("Unable to convert string to draconic ancestry")
        };
    }
}
