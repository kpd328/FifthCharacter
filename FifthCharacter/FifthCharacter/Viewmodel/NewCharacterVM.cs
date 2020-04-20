using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;

/*
 * New Character:
 * 
 * Page 1:\
 * -Name
 * -Player Name
 * -Race
 * -Class
 * -Background
 * -Allignment
 * 
 * Page 2 (if applicable):
 * -Subrace (if applicable)
 * -Race options (if applicable)
 * 
 * Page 3 (if applicable):
 * -Background options (if applicable)
 * 
 * Page 4:
 * -Class options
 * 
 * Page 5 (if applicable):
 * -Magic Options
 * 
 * Page 6:
 * -Ability Scores
 * 
 * Page 7:
 * -Finalize?
 */

namespace FifthCharacter.Viewmodel {
    public class NewCharacterVM : INotifyPropertyChanged {
        PopupNewCharacter Page1;
        private MainPage MainPage;
        public event PropertyChangedEventHandler PropertyChanged;

        //Page 1 Properties
        public string CharacterName {
            get => CharacterManager.CharacterName;
            set {
                if (CharacterManager.CharacterName != value) {
                    CharacterManager.CharacterName = value;
                    OnPropertyChanged("CharacterName");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("CharacterName");
                }
            }
        }
        public string PlayerName {
            get => CharacterManager.PlayerName;
            set {
                if (CharacterManager.PlayerName != value) {
                    CharacterManager.PlayerName = value;
                    OnPropertyChanged("PlayerName");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("PlayerName");
                }
            }
        }
        //TODO: Race select
        public IPlayerClass PlayerClass {
            get => ClassManager.PrimaryClass;
            set {
                if (ClassManager.PrimaryClass != value) {
                    ClassManager.TakeInitialClass(value);
                    OnPropertyChanged("PlayerClass");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("ClassLevel");
                }
                
            }
        }
        //TODO: Background select
        public Alignment Alignment {
            get => CharacterManager.Alignment;
            set {
                if (CharacterManager.Alignment != value) {
                    CharacterManager.Alignment = value;
                    OnPropertyChanged("Alignment");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("Alignment");
                }
            }
        }

        //Page 1 Commands
        private ICommand _page1next;
        public ICommand Page1Next => _page1next ?? (_page1next = new Command(() => {
            //TODO: move on to next page

            //Temp
            PopupNavigation.Instance.PopAsync();
        }));

        //Constructors
        public NewCharacterVM(MainPage mainPage) {
            MainPage = mainPage;

            //TODO: Call to clear all cached data (after moving cahced data to save)
        }

        //Methods
        public void Bind(PopupNewCharacter character) {
            Page1 = character;
            Page1.BindingContext = this;
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Picker Utility
        public string AlignmentString {
            get => Alignment.DisplayString();
            set => Alignment = value.ParseToAlignment();
        }

        public string PlayerClassString {
            get {
                if(PlayerClass != null) {
                    return PlayerClass.Name;
                } else {
                    return null;
                }
            }
            set => PlayerClass = App.Plugins.PlayerClasses.Where(n => n.Name == value).FirstOrDefault();
        }

        public IList<string> PossibleAlignments { get; } = new List<string>() {
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

        public IList<IPlayerClass> PossiblePlayerClasses { get; } = App.Plugins.PlayerClasses;
    }
}
