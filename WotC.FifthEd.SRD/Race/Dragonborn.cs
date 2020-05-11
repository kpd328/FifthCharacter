using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
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
                SelectedItem = ChosenAncestry,
                Title = "Draconic Ancestry",
            };
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
            "Black", "Blue", "Brass", "Bronze", "Copper", "Gold", "Green", "Red", "Silver", "White"
        };

        public string ChosenAncestry {
            get => Ancestry switch {
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
                _ => ""
            };
            set {
                switch (value) {
                    case "Black":
                        Ancestry = DraconicAncestry.BLACK; 
                        break;
                    case "Blue":
                        Ancestry = DraconicAncestry.BLUE;
                        break;
                    case "Brass":
                        Ancestry = DraconicAncestry.BRASS;
                        break;
                    case "Bronze":
                        Ancestry = DraconicAncestry.BRONZE;
                        break;
                    case "Copper":
                        Ancestry = DraconicAncestry.COPPER;
                        break;
                    case "Gold":
                        Ancestry = DraconicAncestry.GOLD;
                        break;
                    case "Green":
                        Ancestry = DraconicAncestry.GREEN;
                        break;
                    case "Red":
                        Ancestry = DraconicAncestry.RED;
                        break;
                    case "Silver":
                        Ancestry = DraconicAncestry.SILVER;
                        break;
                    case "White":
                        Ancestry = DraconicAncestry.WHITE;
                        break;
                }
            }
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
}
