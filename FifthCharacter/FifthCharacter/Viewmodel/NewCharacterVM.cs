using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
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
        private PopupNewCharacter Page1;
        private PopupNewCharacter_GTK Page1_GTK;

        private PopupNCRaceOptions Page2;
        //private PopupNCRaceOptions_GTK Page2_GTK;

        private PopupNCBackgroundOptions Page3;
        //private PopupNCBackgroundOptions_GTK Page3_GTK;

        private PopupNCClassOptions Page4;
        //private PopupNCClassOptions_GTK Page4_GTK;

        private PopupNCMagicOptions Page5;
        //private PopupNCMagicOptions_GTK Page5_GTK;

        private PopupNCAbilityScores Page6;
        //private PopupNCAbilityScores_GTK Page6_GTK;

        private PopupNCFinalize Page7;
        //private PopupNCFinalize_GTK Page7_GTK;

        private MainPage MainPage;
        public event PropertyChangedEventHandler PropertyChanged;

        //Page 1 Properties
        public string CharacterName {
            get => CharacterManager.CharacterName;
            set {
                if (string.IsNullOrEmpty(value)) {
                    IsNameSet = false;
                } else {
                    IsNameSet = true;
                }
                if (CharacterManager.CharacterName != value) {
                    CharacterManager.CharacterName = value;
                    OnPropertyChanged("CharacterName");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("CharacterName");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }
        public string PlayerName {
            get => CharacterManager.PlayerName;
            set {
                if (string.IsNullOrEmpty(value)) {
                    IsPlayernameSet = false;
                } else {
                    IsPlayernameSet = true;
                }
                if (CharacterManager.PlayerName != value) {
                    CharacterManager.PlayerName = value;
                    OnPropertyChanged("PlayerName");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("PlayerName");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }
        public IRace Race {
            get => _selectedRace;
            set {
                if(value == null) {
                    IsRaceSet = false;
                    return;
                }
                _selectedRace = value;
                if(CharacterManager.Race == null || CharacterManager.Race.GetType() != value.GetType()) {
                    IsRaceSet = true;
                    FeaturesManager.RemoveRaceFeatures();
                    CharacterManager.Race = value.GetInstance();
                    OnPropertyChanged("Race");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("Race");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }

        }
        public IPlayerClass PlayerClass {
            get => _selectedPlayerClass;
            set {
                if(value == null) {
                    IsClassSet = false;
                    return;
                }
                _selectedPlayerClass = value;
                if (ClassManager.PrimaryClass == null || ClassManager.PrimaryClass.GetType() != value.GetType()) {
                    IsClassSet = true;
                    ClassManager.TakeInitialClass(value);
                    OnPropertyChanged("PlayerClass");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("ClassLevel");
                    MainPage.FeaturesListView.Viewmodel.OnPropertyChanged("Features");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }
        //TODO: Background select
        public Alignment Alignment {
            get => CharacterManager.Alignment;
            set {
                if(value == Alignment.NONE) {
                    IsAlignmentSet = false;
                }
                if (CharacterManager.Alignment != value) {
                    IsAlignmentSet = true;
                    CharacterManager.Alignment = value;
                    OnPropertyChanged("Alignment");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("Alignment");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }

        //Page 1 Commands
        private ICommand _page1next;
        public ICommand Page1Next => _page1next ?? (_page1next = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    //TODO: determine which page to move on to
                    Page7 = new PopupNCFinalize() { BindingContext = this };
                    PopupNavigation.Instance.PushAsync(Page7);
                    break;
                case Device.GTK:
                    //Page7_GTK = new PopupNCFinalize_GTK() { BindingContext = this };
                    //DependencyService.Get<IPopup>().PushAsync(Page7_GTK);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }, () => Page1CanMoveOn));

        //Page 7 Commands
        private ICommand _page7next;
        public ICommand Page7Next => _page7next ?? (_page7next = new Command(() => {
            PopupNavigation.Instance.PopAllAsync();
        }));

        private ICommand _page7back;
        public ICommand Page7Back => _page7back ?? (_page7back = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    break;
                default:
                    throw new NotImplementedException();
            }
        }));

        //Constructors
        public NewCharacterVM(MainPage mainPage) {
            MainPage = mainPage;

            //TODO: Call to clear all cached data (after moving cahced data to save)
            FeaturesManager.Features.Clear();
        }

        //Methods
        public void Bind(PopupNewCharacter character) {
            Page1 = character;
            Page1.BindingContext = this;
        }

        public void Bind(PopupNewCharacter_GTK character) {
            Page1_GTK = character;
            Page1_GTK.BindingContext = this;
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Picker Utility
        public string AlignmentString {
            get => Alignment.DisplayString();
            set => Alignment = value.ParseToAlignment();
        }

        private IPlayerClass _selectedPlayerClass = ClassManager.PrimaryClass;

        private IRace _selectedRace = CharacterManager.Race;

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

        public IList<IRace> PossibleRaces { get; } = App.Plugins.Races;

        //Validation
        private bool IsNameSet = false, IsPlayernameSet = false, IsRaceSet = false, IsClassSet = false, IsAlignmentSet = false, IsBackgroundSet = true; //TODO: set BackgroundSet to false when implemented
        public bool Page1CanMoveOn => IsNameSet && IsPlayernameSet && IsRaceSet && IsClassSet && IsAlignmentSet && IsBackgroundSet;
    }
}
