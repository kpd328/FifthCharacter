using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using FifthCharacter.Plugin.Tools;
using FifthCharacter.View.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

/*
 * New Character:
 * 
 * Page 1:\
 * -Name
 * -Player Name
 * -Race (with subrace)
 * -Class
 * -Background
 * -Allignment
 * 
 * Page 2 (if applicable):
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
        private PopupNCRaceOptions_GTK Page2_GTK;

        private PopupNCBackgroundOptions Page3;
        private PopupNCBackgroundOptions_GTK Page3_GTK;

        private PopupNCClassOptions Page4;
        private PopupNCClassOptions_GTK Page4_GTK;

        private PopupNCMagicOptions Page5;
        //private PopupNCMagicOptions_GTK Page5_GTK;

        private PopupNCAbilityScores Page6;
        private PopupNCAbilityScores_GTK Page6_GTK;

        private PopupNCFinalize Page7;
        private PopupNCFinalize_GTK Page7_GTK;

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
                    ProficiencyManager.RemoveRaceProficiencies();
                    CharacterManager.Race = value.GetInstance();
                    OnPropertyChanged("Race");
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("Race");
                    MainPage.CharacterDefenseView.Viewmodel.OnPropertyChanged("Speed");
                    MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
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
                    MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.CharacterDefenseView.Viewmodel.OnPropertyChanged("HitDiceTotal");
                    MainPage.CharacterDefenseView.Viewmodel.OnPropertyChanged("HitDiceCurrent");
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }
        public IBackground Background {
            get => _selectedBackground;
            set {
                if(value == null) {
                    IsBackgroundSet = false;
                    return;
                }
                _selectedBackground = value;
                if(CharacterManager.Background == null || CharacterManager.Background.GetType() != value.GetType()) {
                    IsBackgroundSet = true;
                    FeaturesManager.RemoveBackgroundFeatures();
                    ProficiencyManager.RemoveBackgroundProficiencies();
                    CharacterManager.Background = value.GetInstance();
                    MainPage.CharacterInfoView.Viewmodel.OnPropertyChanged("Background");
                    MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
                    MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
                }
                OnPropertyChanged("Page1CanMoveOn");
            }
        }
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

        //Ability Score (Page 6) Properties
        private enum ScoreType {
            POINT_BUY,
            STANDARD_ARRAY,
            ROLL,
            MANUAL_ENTRY
        }
        private ScoreType scoreType { get; set; } = ScoreType.POINT_BUY;
        public int PointsLeft { get; set; } = 27;

        public string PointsText => PointsLeft.ToString();

        public int PointStr => 8 + PointsToAbilityScore(StrAllocPts);
        public int PointDex => 8 + PointsToAbilityScore(DexAllocPts);
        public int PointCon => 8 + PointsToAbilityScore(ConAllocPts);
        public int PointInt => 8 + PointsToAbilityScore(IntAllocPts);
        public int PointWis => 8 + PointsToAbilityScore(WisAllocPts);
        public int PointCha => 8 + PointsToAbilityScore(ChaAllocPts);

        private int StrAllocPts;
        private int DexAllocPts;
        private int ConAllocPts;
        private int IntAllocPts;
        private int WisAllocPts;
        private int ChaAllocPts;

        private bool StrPtMin => StrAllocPts > 0;
        private bool StrPtMax => StrAllocPts < 9;
        private bool DexPtMin => DexAllocPts > 0;
        private bool DexPtMax => DexAllocPts < 9;
        private bool ConPtMin => ConAllocPts > 0;
        private bool ConPtMax => ConAllocPts < 9;
        private bool IntPtMin => IntAllocPts > 0;
        private bool IntPtMax => IntAllocPts < 9;
        private bool WisPtMin => WisAllocPts > 0;
        private bool WisPtMax => WisAllocPts < 9;
        private bool ChaPtMin => ChaAllocPts > 0;
        private bool ChaPtMax => ChaAllocPts < 9;
        private bool HasPointsLeft => PointsLeft > 0;

        public int ArrayStr { get; set; } = 15;
        public int ArrayDex { get; set; } = 14;
        public int ArrayCon { get; set; } = 13;
        public int ArrayInt { get; set; } = 12;
        public int ArrayWis { get; set; } = 10;
        public int ArrayCha { get; set; } = 8;

        public int RollStr { get; set; }
        public int RollDex { get; set; }
        public int RollCon { get; set; }
        public int RollInt { get; set; }
        public int RollWis { get; set; }
        public int RollCha { get; set; }

        private bool RollModernClickable { get; set; } = true;
        private bool RollClassicClickable { get; set; } = true;
        private bool RollMulliganClickable { get; set; } = true;

        private RollMode CurrentRollMode = RollMode.NONE;
        private bool CanRoll => CurrentRollMode != RollMode.NONE;

        private int ManStr;
        public string ManualStr {
            get => AbilityManager.StrengthScore.ToString();
            set {
                int _str;
                if (int.TryParse(value, out _str)) {
                    ManStr = _str;
                    MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        private int ManDex;
        public string ManualDex {
            get => AbilityManager.DexterityScore.ToString();
            set {
                int _dex;
                if (int.TryParse(value, out _dex)) {
                    ManDex = _dex;
                    MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        private int ManCon;
        public string ManualCon {
            get => AbilityManager.ConstitutionScore.ToString();
            set {
                int _con;
                if (int.TryParse(value, out _con)) {
                    ManCon = _con;
                    MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        private int ManInt;
        public string ManualInt {
            get => AbilityManager.IntelligenceScore.ToString();
            set {
                int _int;
                if (int.TryParse(value, out _int)) {
                    ManInt = _int;
                    MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        private int ManWis;
        public string ManualWis {
            get => AbilityManager.WisdomScore.ToString();
            set {
                int _wis;
                if (int.TryParse(value, out _wis)) {
                    ManWis = _wis;
                    MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        private int ManCha;
        public string ManualCha {
            get => AbilityManager.CharismaScore.ToString();
            set {
                int _cha;
                if (int.TryParse(value, out _cha)) {
                    ManCha = _cha;
                    MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }

        public string RacialASI => FeaturesManager.Features.Where(f => f.Name == "Ability Score Increase").FirstOrDefault().Text;

        //Page 1 Commands
        private ICommand _page1next;
        public ICommand Page1Next => _page1next ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    if (CharacterManager.Race.HasChoices) {
                        Page2 = new PopupNCRaceOptions() { BindingContext = this };
                        CharacterManager.Race.BuildPopup(Page2);
                        PopupNavigation.Instance.PushAsync(Page2);
                    } else if (CharacterManager.Background.HasChoices) {
                        Page3 = new PopupNCBackgroundOptions() { BindingContext = this };
                        CharacterManager.Background.BuildPopup(Page3);
                        PopupNavigation.Instance.PushAsync(Page3);
                    } else {
                        Page4 = new PopupNCClassOptions() { BindingContext = this };
                        ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                        PopupNavigation.Instance.PushAsync(Page4);
                    }
                    break;
                case Device.GTK:
                    if (CharacterManager.Race.HasChoices) {
                        Page2_GTK = new PopupNCRaceOptions_GTK() { BindingContext = this };
                        CharacterManager.Race.BuildPopup(Page2_GTK);
                        DependencyService.Get<IPopup>().PushAsync(Page2_GTK);
                    } else if (CharacterManager.Background.HasChoices) {
                        Page3_GTK = new PopupNCBackgroundOptions_GTK() { BindingContext = this };
                        CharacterManager.Background.BuildPopup(Page3_GTK);
                        DependencyService.Get<IPopup>().PushAsync(Page3_GTK);
                    } else {
                        Page4_GTK = new PopupNCClassOptions_GTK() { BindingContext = this };
                        ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                        DependencyService.Get<IPopup>().PushAsync(Page4_GTK);
                    }
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }, () => Page1CanMoveOn);

        //Page 2 Commands
        private ICommand _page2next;
        public ICommand Page2Next => _page2next ??= new Command(() => {
            CharacterManager.Race.ConfirmPopup();
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    if (CharacterManager.Background.HasChoices) {
                        Page3 = new PopupNCBackgroundOptions() { BindingContext = this };
                        CharacterManager.Background.BuildPopup(Page3);
                        PopupNavigation.Instance.PushAsync(Page3);
                    } else {
                        Page4 = new PopupNCClassOptions() { BindingContext = this };
                        ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                        PopupNavigation.Instance.PushAsync(Page4);
                    }
                    break;
                case Device.GTK:
                    if (CharacterManager.Background.HasChoices) {
                        Page3_GTK = new PopupNCBackgroundOptions_GTK() { BindingContext = this };
                        CharacterManager.Background.BuildPopup(Page3_GTK);
                        DependencyService.Get<IPopup>().PushAsync(Page3_GTK);
                    } else {
                        Page4_GTK = new PopupNCClassOptions_GTK() { BindingContext = this };
                        ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                        DependencyService.Get<IPopup>().PushAsync(Page4_GTK);
                    }
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _page2back;
        public ICommand Page2Back => _page2back ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but I should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        //Page 3 Commands
        private ICommand _page3next;
        public ICommand Page3Next => _page3next ??= new Command(() => {
            CharacterManager.Background.ConfirmPopup();
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page4 = new PopupNCClassOptions() { BindingContext = this };
                    ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                    PopupNavigation.Instance.PushAsync(Page4);
                    break;
                case Device.GTK:
                    Page4_GTK = new PopupNCClassOptions_GTK() { BindingContext = this };
                    ClassManager.PrimaryClass.BuildNewCharacterPopup(Page4.Body);
                    DependencyService.Get<IPopup>().PushAsync(Page4_GTK);
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _page3back;
        public ICommand Page3Back => _page3back ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but I should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        //Page 4 Commands
        private ICommand _page4next;
        public ICommand Page4Next => _page4next ??= new Command(() => {
            ClassManager.PrimaryClass.ConfirmNewCharacterPopup();
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    //TODO: determine whether or not to go to page 5
                    Page6 = new PopupNCAbilityScores() { BindingContext = this, Callback = new Action<string>(StringToScoreType) };
                    PopupNavigation.Instance.PushAsync(Page6);
                    break;
                case Device.GTK:
                    //TODO: determine whether or not to go to page 5
                    Page6_GTK = new PopupNCAbilityScores_GTK() { BindingContext = this };
                    DependencyService.Get<IPopup>().PushAsync(Page6_GTK);
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _page4back;
        public ICommand Page4Back => _page4back ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but I should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        //Page 6 Commands
        private ICommand _page6next;
        public ICommand Page6Next => _page6next ??= new Command(() => {
            //finalize
            switch (scoreType) {
                case ScoreType.POINT_BUY:
                    AbilityManager.StrengthScore = PointStr;
                    AbilityManager.DexterityScore = PointDex;
                    AbilityManager.ConstitutionScore = PointCon;
                    AbilityManager.IntelligenceScore = PointInt;
                    AbilityManager.WisdomScore = PointWis;
                    AbilityManager.CharismaScore = PointCha;
                    break;
                case ScoreType.STANDARD_ARRAY:
                    AbilityManager.StrengthScore = ArrayStr;
                    AbilityManager.DexterityScore = ArrayDex;
                    AbilityManager.ConstitutionScore = ArrayCon;
                    AbilityManager.IntelligenceScore = ArrayInt;
                    AbilityManager.WisdomScore = ArrayWis;
                    AbilityManager.CharismaScore = ArrayCha;
                    break;
                case ScoreType.ROLL:
                    AbilityManager.StrengthScore = RollStr;
                    AbilityManager.DexterityScore = RollDex;
                    AbilityManager.ConstitutionScore = RollCon;
                    AbilityManager.IntelligenceScore = RollInt;
                    AbilityManager.WisdomScore = RollWis;
                    AbilityManager.CharismaScore = RollCha;
                    break;
                case ScoreType.MANUAL_ENTRY:
                    AbilityManager.StrengthScore = ManStr;
                    AbilityManager.DexterityScore = ManDex;
                    AbilityManager.ConstitutionScore = ManCon;
                    AbilityManager.IntelligenceScore = ManInt;
                    AbilityManager.WisdomScore = ManWis;
                    AbilityManager.CharismaScore = ManCha;
                    break;
            }
            FeaturesManager.Features.Where(f => f.Name == "Ability Score Increase").FirstOrDefault().ModAbility();
            MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
            MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
            MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
            MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
            MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
            MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page7 = new PopupNCFinalize() { BindingContext = this };
                    PopupNavigation.Instance.PushAsync(Page7);
                    break;
                case Device.GTK:
                    Page7_GTK = new PopupNCFinalize_GTK() { BindingContext = this };
                    DependencyService.Get<IPopup>().PushAsync(Page7_GTK);
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _page6back;
        public ICommand Page6Back => _page6back ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but I should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _pointStrSubtract;
        public ICommand PointStrSubtract => _pointStrSubtract ??= new Command(() => {
            switch (StrAllocPts) {
                case 7:
                case 9:
                    StrAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    StrAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => StrPtMin);

        private ICommand _pointStrAdd;
        public ICommand PointStrAdd => _pointStrAdd ??= new Command(() => {
            switch (StrAllocPts) {
                case 7:
                case 5:
                    StrAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    StrAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => StrPtMax && HasPointsLeft);

        private ICommand _pointDexSubtract;
        public ICommand PointDexSubtract => _pointDexSubtract ??= new Command(() => {
            switch (DexAllocPts) {
                case 7:
                case 9:
                    DexAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    DexAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => DexPtMin);

        private ICommand _pointDexAdd;
        public ICommand PointDexAdd => _pointDexAdd ??= new Command(() => {
            switch (DexAllocPts) {
                case 7:
                case 5:
                    DexAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    DexAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => DexPtMax && HasPointsLeft);

        private ICommand _pointConSubtract;
        public ICommand PointConSubtract => _pointConSubtract ??= new Command(() => {
            switch (ConAllocPts) {
                case 7:
                case 9:
                    ConAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    ConAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => ConPtMin);

        private ICommand _pointConAdd;
        public ICommand PointConAdd => _pointConAdd ??= new Command(() => {
            switch (ConAllocPts) {
                case 7:
                case 5:
                    ConAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    ConAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => ConPtMax && HasPointsLeft);

        private ICommand _pointIntSubtract;
        public ICommand PointIntSubtract => _pointIntSubtract ??= new Command(() => {
            switch (IntAllocPts) {
                case 7:
                case 9:
                    IntAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    IntAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => IntPtMin);

        private ICommand _pointIntAdd;
        public ICommand PointIntAdd => _pointIntAdd ??= new Command(() => {
            switch (IntAllocPts) {
                case 7:
                case 5:
                    IntAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    IntAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => IntPtMax && HasPointsLeft);

        private ICommand _pointWisSubtract;
        public ICommand PointWisSubtract => _pointWisSubtract ??= new Command(() => {
            switch (WisAllocPts) {
                case 7:
                case 9:
                    WisAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    WisAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => WisPtMin);

        private ICommand _pointWisAdd;
        public ICommand PointWisAdd => _pointWisAdd ??= new Command(() => {
            switch (WisAllocPts) {
                case 7:
                case 5:
                    WisAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    WisAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => WisPtMax && HasPointsLeft);

        private ICommand _pointChaSubtract;
        public ICommand PointChaSubtract => _pointChaSubtract ??= new Command(() => {
            switch (ChaAllocPts) {
                case 7:
                case 9:
                    ChaAllocPts -= 2;
                    PointsLeft += 2;
                    break;
                case 0:
                    break;
                default:
                    ChaAllocPts--;
                    PointsLeft++;
                    break;
            }
            RefreshPoints();
        }, () => ChaPtMin);

        private ICommand _pointChaAdd;
        public ICommand PointChaAdd => _pointChaAdd ??= new Command(() => {
            switch (ChaAllocPts) {
                case 7:
                case 5:
                    ChaAllocPts += 2;
                    PointsLeft -= 2;
                    break;
                case 9:
                    break;
                default:
                    ChaAllocPts++;
                    PointsLeft--;
                    break;
            }
            RefreshPoints();
        }, () => ChaPtMax && HasPointsLeft);

        private ICommand _arrayStrDexSwap;
        public ICommand ArrayStrDexSwap => _arrayStrDexSwap ??= new Command(() => {
            var _temp = ArrayStr;
            ArrayStr = ArrayDex;
            ArrayDex = _temp;
            OnPropertyChanged("ArrayStr");
            OnPropertyChanged("ArrayDex");
            RefreshArray();
        });

        private ICommand _arrayDexConSwap;
        public ICommand ArrayDexConSwap => _arrayDexConSwap ??= new Command(() => {
            var _temp = ArrayDex;
            ArrayDex = ArrayCon;
            ArrayCon = _temp;
            OnPropertyChanged("ArrayDex");
            OnPropertyChanged("ArrayCon");
            RefreshArray();
        });

        private ICommand _arrayConIntSwap;
        public ICommand ArrayConIntSwap => _arrayConIntSwap ??= new Command(() => {
            var _temp = ArrayCon;
            ArrayCon = ArrayInt;
            ArrayInt = _temp;
            OnPropertyChanged("ArrayCon");
            OnPropertyChanged("ArrayInt");
            RefreshArray();
        });

        private ICommand _arrayIntWisSwap;
        public ICommand ArrayIntWisSwap => _arrayIntWisSwap ??= new Command(() => {
            var _temp = ArrayInt;
            ArrayInt = ArrayWis;
            ArrayWis = _temp;
            OnPropertyChanged("ArrayInt");
            OnPropertyChanged("ArrayWis");
            RefreshArray();
        });

        private ICommand _arrayWisChaSwap;
        public ICommand ArrayWisChaSwap => _arrayWisChaSwap ??= new Command(() => {
            var _temp = ArrayWis;
            ArrayWis = ArrayCha;
            ArrayCha = _temp;
            OnPropertyChanged("ArrayWis");
            OnPropertyChanged("ArrayCha");
            RefreshArray();
        });

        private ICommand _rollModernButton;
        public ICommand RollModernButton => _rollModernButton ??= new Command(() => {
            CurrentRollMode = RollMode.MODERN;
            RollModernClickable = false;
            RollClassicClickable = true;
            RollMulliganClickable = true;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollModernClickable);

        private ICommand _rollClassicButton;
        public ICommand RollClassicButton => _rollClassicButton ??= new Command(() => {
            CurrentRollMode = RollMode.CLASSIC;
            RollModernClickable = true;
            RollClassicClickable = false;
            RollMulliganClickable = true;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollClassicClickable);

        private ICommand _rollMulliganButton;
        public ICommand RollMulliganButton => _rollMulliganButton ??= new Command(() => {
            CurrentRollMode = RollMode.MULLIGAN;
            RollModernClickable = true;
            RollClassicClickable = true;
            RollMulliganClickable = false;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollMulliganClickable);

        private ICommand _rollButton;
        public ICommand RollButton => _rollButton ??= new Command(() => {
            Random random = new Random();
            switch (CurrentRollMode) {
                case RollMode.MODERN:
                    int[] _rolls = new int[6];
                    for(int i = 0; i < 6; i++) {
                        List<int> _temp = new List<int>() {
                            random.Next(1, 7),
                            random.Next(1, 7),
                            random.Next(1, 7),
                            random.Next(1, 7)
                        };
                        _temp.Remove(_temp.Min());
                        _rolls[i] = _temp.Sum();
                    }
                    RollStr = _rolls[0];
                    RollDex = _rolls[1];
                    RollCon = _rolls[2];
                    RollInt = _rolls[3];
                    RollWis = _rolls[4];
                    RollCha = _rolls[5];
                    break;
                case RollMode.CLASSIC:
                    RollStr = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    RollDex = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    RollCon = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    RollInt = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    RollWis = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    RollCha = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                    break;
                case RollMode.MULLIGAN:
                    RollStr = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    RollDex = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    RollCon = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    RollInt = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    RollWis = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    RollCha = Math.Max(random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7),
                        random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7));
                    break;
                default:
                    break;
            }
            OnPropertyChanged("RollStr");
            OnPropertyChanged("RollDex");
            OnPropertyChanged("RollCon");
            OnPropertyChanged("RollInt");
            OnPropertyChanged("RollWis");
            OnPropertyChanged("RollCha");
        }, () => CanRoll);

        private ICommand _rollStrDexSwap;
        public ICommand RollStrDexSwap => _rollStrDexSwap ??= new Command(() => {
            var _temp = RollStr;
            RollStr = RollDex;
            RollDex = _temp;
            OnPropertyChanged("RollStr");
            OnPropertyChanged("RollDex");
        });

        private ICommand _rollDexConSwap;
        public ICommand RollDexConSwap => _rollDexConSwap ??= new Command(() => {
            var _temp = RollDex;
            RollDex = RollCon;
            RollCon = _temp;
            OnPropertyChanged("RollDex");
            OnPropertyChanged("RollCon");
        });

        private ICommand _rollConIntSwap;
        public ICommand RollConIntSwap => _rollConIntSwap ??= new Command(() => {
            var _temp = RollCon;
            RollCon = RollInt;
            RollInt = _temp;
            OnPropertyChanged("RollCon");
            OnPropertyChanged("RollInt");
        });

        private ICommand _rollIntWisSwap;
        public ICommand RollIntWisSwap => _rollIntWisSwap ??= new Command(() => {
            var _temp = RollInt;
            RollInt = RollWis;
            RollWis = _temp;
            OnPropertyChanged("RollInt");
            OnPropertyChanged("RollWis");
        });

        private ICommand _rollWisChaSwap;
        public ICommand RollWisChaSwap => _rollWisChaSwap ??= new Command(() => {
            var _temp = RollWis;
            RollWis = RollCha;
            RollCha = _temp;
            OnPropertyChanged("RollWis");
            OnPropertyChanged("RollCha");
        });

        //Page 7 Commands
        private ICommand _page7next;
        public ICommand Page7Next => _page7next ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAllAsync();
                    break;
                case Device.GTK:
                    //TODO: figure out how to close the window completely
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        private ICommand _page7back;
        public ICommand Page7Back => _page7back ??= new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PopAsync();
                    break;
                case Device.GTK:
                    //TODO: pop this page and go to the previous page
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but it should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        });

        //Constructors
        public NewCharacterVM(MainPage mainPage) {
            MainPage = mainPage;

            //TODO: Call to clear all cached data (after moving cahced data to save)
            FeaturesManager.Features.Clear();
            ProficiencyManager.Proficiencies.Clear();
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

        private int PointsToAbilityScore(int points) => points switch {
            7 => 6,
            9 => 7,
            _ => points
        };

        private void RefreshArray() {
            AbilityManager.StrengthScore = ArrayStr;
            AbilityManager.DexterityScore = ArrayDex;
            AbilityManager.ConstitutionScore = ArrayCon;
            AbilityManager.IntelligenceScore = ArrayInt;
            AbilityManager.WisdomScore = ArrayWis;
            AbilityManager.CharismaScore = ArrayCha;
        }

        private void RefreshPoints() {
            OnPropertyChanged("StrPtMin");
            OnPropertyChanged("StrPtMax");
            OnPropertyChanged("DexPtMin");
            OnPropertyChanged("DexPtMax");
            OnPropertyChanged("ConPtMin");
            OnPropertyChanged("ConPtMax");
            OnPropertyChanged("IntPtMin");
            OnPropertyChanged("IntPtMax");
            OnPropertyChanged("WisPtMin");
            OnPropertyChanged("WisPtMax");
            OnPropertyChanged("ChaPtMin");
            OnPropertyChanged("ChaPtMax");
            OnPropertyChanged("PointStr");
            OnPropertyChanged("PointDex");
            OnPropertyChanged("PointCon");
            OnPropertyChanged("PointInt");
            OnPropertyChanged("PointWis");
            OnPropertyChanged("PointCha");
            OnPropertyChanged("PointsText");
            ((Command)_pointStrSubtract).ChangeCanExecute();
            ((Command)_pointStrAdd).ChangeCanExecute();
            ((Command)_pointDexSubtract).ChangeCanExecute();
            ((Command)_pointDexAdd).ChangeCanExecute();
            ((Command)_pointConSubtract).ChangeCanExecute();
            ((Command)_pointConAdd).ChangeCanExecute();
            ((Command)_pointIntSubtract).ChangeCanExecute();
            ((Command)_pointIntAdd).ChangeCanExecute();
            ((Command)_pointWisSubtract).ChangeCanExecute();
            ((Command)_pointWisAdd).ChangeCanExecute();
            ((Command)_pointChaSubtract).ChangeCanExecute();
            ((Command)_pointChaAdd).ChangeCanExecute();
        }

        //Picker Utility
        public string AlignmentString {
            get => Alignment.DisplayString();
            set => Alignment = value.ParseToAlignment();
        }

        private IPlayerClass _selectedPlayerClass = ClassManager.PrimaryClass;

        private IRace _selectedRace = CharacterManager.Race;

        private IBackground _selectedBackground = CharacterManager.Background;

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

        public IList<IBackground> PossibleBackgrounds { get; } = App.Plugins.Backgrounds;

        //Validation
        private bool IsNameSet = false, IsPlayernameSet = false, IsRaceSet = false, IsClassSet = false, IsAlignmentSet = false, IsBackgroundSet = false; //TODO: set BackgroundSet to false when implemented
        public bool Page1CanMoveOn => IsNameSet && IsPlayernameSet && IsRaceSet && IsClassSet && IsAlignmentSet && IsBackgroundSet;

        private enum RollMode {
            NONE,
            MODERN,
            CLASSIC,
            MULLIGAN
        }

        public void StringToScoreType(string s) {
            switch (s) {
                case "Point Buy":
                    scoreType = ScoreType.POINT_BUY;
                    break;
                case "Standard Array":
                    scoreType = ScoreType.STANDARD_ARRAY;
                    break;
                case "Roll":
                    scoreType = ScoreType.ROLL;
                    break;
                case "Manual Entry":
                    scoreType = ScoreType.MANUAL_ENTRY;
                    break;
                default:
                    break;
            }
        }
    }
}
