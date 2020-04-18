using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Viewmodel {
    public class NewCharacterVM {
        PopupNewCharacter Page1;

        //Page 1 Properties
        public string Name {
            get => CharacterManager.CharacterName;
            set => CharacterManager.CharacterName = value;
        }
        public string PlayerName { 
            get => CharacterManager.PlayerName;
            set => CharacterManager.PlayerName = value;
        }
        //TODO: Race select
        //TODO: Class select
        //TODO: Background select
        public Alignment Alignment {
            get => CharacterManager.Alignment;
            set => CharacterManager.Alignment = value;
        }
        public string AlignmentString {
            get => Alignment.DisplayString();
            set => Alignment = value.ParseToAlignment();
        }

        //Page 1 Commands
        private ICommand _page1next;
        public ICommand Page1Next => _page1next ?? (_page1next = new Command(() => {
            //TODO: move on to next page

            //Temp
            PopupNavigation.Instance.PopAsync();
        }));

        //Methods
        public void Bind(PopupNewCharacter character) {
            Page1 = character;
            Page1.BindingContext = this;
        }

        //Private Enum Lists
        public static IList<string> PossibleAlignments { get; } = new List<string>() {
            Alignment.LAWFUL_GOOD.DisplayString(),
            Alignment.NEUTRAL_GOOD.DisplayString(),
            Alignment.CHAOTIC_GOOD.DisplayString(),
            Alignment.LAWFUL_NEUTRAL.DisplayString(),
            Alignment.NEUTRAL.DisplayString(),
            Alignment.CHAOTIC_NEUTRAL.DisplayString(),
            Alignment.LAWFUL_EVIL.DisplayString(),
            Alignment.NEUTRAL_EVIL.DisplayString(),
            Alignment.CHAOTIC_EVIL.DisplayString()
        };
    }
}
