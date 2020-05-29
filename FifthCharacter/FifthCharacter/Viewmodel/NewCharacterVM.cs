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
        //private PopupNCClassOptions_GTK Page4_GTK;

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

        public string ManualStr {
            get => AbilityManager.StrengthScore.ToString();
            set {
                int _str;
                if (int.TryParse(value, out _str)) {
                    AbilityManager.StrengthScore = _str;
                    MainPage.StrengthAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        public string ManualDex {
            get => AbilityManager.DexterityScore.ToString();
            set {
                int _dex;
                if (int.TryParse(value, out _dex)) {
                    AbilityManager.DexterityScore = _dex;
                    MainPage.DexterityAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        public string ManualCon {
            get => AbilityManager.ConstitutionScore.ToString();
            set {
                int _con;
                if (int.TryParse(value, out _con)) {
                    AbilityManager.ConstitutionScore = _con;
                    MainPage.ConstitutionAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        public string ManualInt {
            get => AbilityManager.IntelligenceScore.ToString();
            set {
                int _int;
                if (int.TryParse(value, out _int)) {
                    AbilityManager.IntelligenceScore = _int;
                    MainPage.IntellegenceAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        public string ManualWis {
            get => AbilityManager.WisdomScore.ToString();
            set {
                int _wis;
                if (int.TryParse(value, out _wis)) {
                    AbilityManager.WisdomScore = _wis;
                    MainPage.WisdomAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }
        public string ManualCha {
            get => AbilityManager.CharismaScore.ToString();
            set {
                int _cha;
                if (int.TryParse(value, out _cha)) {
                    AbilityManager.CharismaScore = _cha;
                    MainPage.CharismaAbilityView.Viewmodel.AllPropertiesChanged();
                }
            }
        }

        public string RacialASI => FeaturesManager.Features.Where(f => f.Name == "Ability Score Increase").FirstOrDefault().Text;

        //Page 1 Commands
        private ICommand _page1next;
        public ICommand Page1Next => _page1next ?? (_page1next = new Command(() => {
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
                        //TODO: go to page 4 instead
                        Page7 = new PopupNCFinalize() { BindingContext = this };
                        PopupNavigation.Instance.PushAsync(Page7);
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
                        //TODO: go to page 4 instead
                        Page7_GTK = new PopupNCFinalize_GTK() { BindingContext = this };
                        DependencyService.Get<IPopup>().PushAsync(Page7_GTK);
                    }
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }, () => Page1CanMoveOn));

        //Page 2 Commands
        private ICommand _page2next;
        public ICommand Page2Next => _page2next ?? (_page2next = new Command(() => {
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
                        //TODO: go to page 4 instead
                        Page7 = new PopupNCFinalize() { BindingContext = this };
                        PopupNavigation.Instance.PushAsync(Page7);
                    }
                    break;
                case Device.GTK:
                    if (CharacterManager.Background.HasChoices) {
                        Page3_GTK = new PopupNCBackgroundOptions_GTK() { BindingContext = this };
                        CharacterManager.Background.BuildPopup(Page3_GTK);
                        DependencyService.Get<IPopup>().PushAsync(Page3_GTK);
                    } else {
                        //TODO: go to page 4 instead
                        Page7_GTK = new PopupNCFinalize_GTK() { BindingContext = this };
                        DependencyService.Get<IPopup>().PushAsync(Page7_GTK);
                    }
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _page2back;
        public ICommand Page2Back => _page2back ?? (_page2back = new Command(() => {
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
        }));

        //Page 3 Commands
        private ICommand _page3next;
        public ICommand Page3Next => _page3next ?? (_page3next = new Command(() => {
            CharacterManager.Background.ConfirmPopup();
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    //TODO: go to page 4 instead
                    Page6 = new PopupNCAbilityScores() { BindingContext = this };
                    PopupNavigation.Instance.PushAsync(Page6);
                    break;
                case Device.GTK:
                    //TODO: go to page 4 instead
                    Page6_GTK = new PopupNCAbilityScores_GTK() { BindingContext = this };
                    DependencyService.Get<IPopup>().PushAsync(Page6_GTK);
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _page3back;
        public ICommand Page3Back => _page3back ?? (_page3back = new Command(() => {
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
        }));

        //Page 6 Commands
        private ICommand _page6next;
        public ICommand Page6Next => _page6next ?? (_page6next = new Command(() => {
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
        }));

        private ICommand _page6back;
        public ICommand Page6Back => _page6back ?? (_page6back = new Command(() => {
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
        }));

        private ICommand _page6points;
        public ICommand Page6Points => _page6points ?? (_page6points = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page6.PointBuy.IsVisible = true;
                    Page6.StandardArray.IsVisible = false;
                    Page6.Roll.IsVisible = false;
                    Page6.ManualEntry.IsVisible = false;
                    Page6.PointBuyButton.IsEnabled = false;
                    Page6.StandardArrayButton.IsEnabled = true;
                    Page6.RollButton.IsEnabled = true;
                    Page6.ManualEntryButton.IsEnabled = true;
                    break;
                case Device.GTK:
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _page6array;
        public ICommand Page6Array => _page6array ?? (_page6array = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page6.PointBuy.IsVisible = false;
                    Page6.StandardArray.IsVisible = true;
                    Page6.Roll.IsVisible = false;
                    Page6.ManualEntry.IsVisible = false;
                    Page6.PointBuyButton.IsEnabled = true;
                    Page6.StandardArrayButton.IsEnabled = false;
                    Page6.RollButton.IsEnabled = true;
                    Page6.ManualEntryButton.IsEnabled = true;
                    break;
                case Device.GTK:
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _page6roll;
        public ICommand Page6Roll => _page6roll ?? (_page6roll = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page6.PointBuy.IsVisible = false;
                    Page6.StandardArray.IsVisible = false;
                    Page6.Roll.IsVisible = true;
                    Page6.ManualEntry.IsVisible = false;
                    Page6.PointBuyButton.IsEnabled = true;
                    Page6.StandardArrayButton.IsEnabled = true;
                    Page6.RollButton.IsEnabled = false;
                    Page6.ManualEntryButton.IsEnabled = true;
                    break;
                case Device.GTK:
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _page6manual;
        public ICommand Page6Manual => _page6manual ?? (_page6manual = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    Page6.PointBuy.IsVisible = false;
                    Page6.StandardArray.IsVisible = false;
                    Page6.Roll.IsVisible = false;
                    Page6.ManualEntry.IsVisible = true;
                    Page6.PointBuyButton.IsEnabled = true;
                    Page6.StandardArrayButton.IsEnabled = true;
                    Page6.RollButton.IsEnabled = true;
                    Page6.ManualEntryButton.IsEnabled = false;
                    break;
                case Device.GTK:
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

        private ICommand _pointStrSubtract;
        public ICommand PointStrSubtract => _pointStrSubtract ?? (_pointStrSubtract = new Command(() => {
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
        }, () => StrPtMin));

        private ICommand _pointStrAdd;
        public ICommand PointStrAdd => _pointStrAdd ?? (_pointStrAdd = new Command(() => {
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
        }, () => StrPtMax && HasPointsLeft));

        private ICommand _pointDexSubtract;
        public ICommand PointDexSubtract => _pointDexSubtract ?? (_pointDexSubtract = new Command(() => {
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
        }, () => DexPtMin));

        private ICommand _pointDexAdd;
        public ICommand PointDexAdd => _pointDexAdd ?? (_pointDexAdd = new Command(() => {
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
        }, () => DexPtMax && HasPointsLeft));

        private ICommand _pointConSubtract;
        public ICommand PointConSubtract => _pointConSubtract ?? (_pointConSubtract = new Command(() => {
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
        }, () => ConPtMin));

        private ICommand _pointConAdd;
        public ICommand PointConAdd => _pointConAdd ?? (_pointConAdd = new Command(() => {
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
        }, () => ConPtMax && HasPointsLeft));

        private ICommand _pointIntSubtract;
        public ICommand PointIntSubtract => _pointIntSubtract ?? (_pointIntSubtract = new Command(() => {
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
        }, () => IntPtMin));

        private ICommand _pointIntAdd;
        public ICommand PointIntAdd => _pointIntAdd ?? (_pointIntAdd = new Command(() => {
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
        }, () => IntPtMax && HasPointsLeft));

        private ICommand _pointWisSubtract;
        public ICommand PointWisSubtract => _pointWisSubtract ?? (_pointWisSubtract = new Command(() => {
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
        }, () => WisPtMin));

        private ICommand _pointWisAdd;
        public ICommand PointWisAdd => _pointWisAdd ?? (_pointWisAdd = new Command(() => {
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
        }, () => WisPtMax && HasPointsLeft));

        private ICommand _pointChaSubtract;
        public ICommand PointChaSubtract => _pointChaSubtract ?? (_pointChaSubtract = new Command(() => {
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
        }, () => ChaPtMin));

        private ICommand _pointChaAdd;
        public ICommand PointChaAdd => _pointChaAdd ?? (_pointChaAdd = new Command(() => {
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
        }, () => ChaPtMax && HasPointsLeft));

        private ICommand _rollModernButton;
        public ICommand RollModernButton => _rollModernButton ?? (_rollModernButton = new Command(() => {
            CurrentRollMode = RollMode.MODERN;
            RollModernClickable = false;
            RollClassicClickable = true;
            RollMulliganClickable = true;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollModernClickable));

        private ICommand _rollClassicButton;
        public ICommand RollClassicButton => _rollClassicButton ?? (_rollClassicButton = new Command(() => {
            CurrentRollMode = RollMode.CLASSIC;
            RollModernClickable = true;
            RollClassicClickable = false;
            RollMulliganClickable = true;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollClassicClickable));

        private ICommand _rollMulliganButton;
        public ICommand RollMulliganButton => _rollMulliganButton ?? (_rollMulliganButton = new Command(() => {
            CurrentRollMode = RollMode.MULLIGAN;
            RollModernClickable = true;
            RollClassicClickable = true;
            RollMulliganClickable = false;
            OnPropertyChanged("RollModernClickable");
            OnPropertyChanged("RollClassicClickable");
            OnPropertyChanged("RollMulliganClickable");
            OnPropertyChanged("CanRoll");
        }, () => RollMulliganClickable));

        private ICommand _rollButton;
        public ICommand RollButton => _rollButton ?? (_rollButton = new Command(() => {
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
        }, () => CanRoll));

        private ICommand _rollStrDexSwap;
        public ICommand RollStrDexSwap => _rollStrDexSwap ?? (_rollStrDexSwap = new Command(() => {
            var _temp = RollStr;
            RollStr = RollDex;
            RollDex = _temp;
            OnPropertyChanged("RollStr");
            OnPropertyChanged("RollDex");
        }));

        private ICommand _rollDexConSwap;
        public ICommand RollDexConSwap => _rollDexConSwap ?? (_rollDexConSwap = new Command(() => {
            var _temp = RollDex;
            RollDex = RollCon;
            RollCon = _temp;
            OnPropertyChanged("RollDex");
            OnPropertyChanged("RollCon");
        }));

        private ICommand _rollConIntSwap;
        public ICommand RollConIntSwap => _rollConIntSwap ?? (_rollConIntSwap = new Command(() => {
            var _temp = RollCon;
            RollCon = RollInt;
            RollInt = _temp;
            OnPropertyChanged("RollCon");
            OnPropertyChanged("RollInt");
        }));

        private ICommand _rollIntWisSwap;
        public ICommand RollIntWisSwap => _rollIntWisSwap ?? (_rollIntWisSwap = new Command(() => {
            var _temp = RollInt;
            RollInt = RollWis;
            RollWis = _temp;
            OnPropertyChanged("RollInt");
            OnPropertyChanged("RollWis");
        }));

        private ICommand _rollWisChaSwap;
        public ICommand RollWisChaSwap => _rollWisChaSwap ?? (_rollWisChaSwap = new Command(() => {
            var _temp = RollWis;
            RollWis = RollCha;
            RollCha = _temp;
            OnPropertyChanged("RollWis");
            OnPropertyChanged("RollCha");
        }));

        //Page 7 Commands
        private ICommand _page7next;
        public ICommand Page7Next => _page7next ?? (_page7next = new Command(() => {
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
                    DependencyService.Get<IPopup>().PopAsync(); //idk if this works, but it should make it work
                    break;
                default:
                    throw new NotImplementedException(Device.RuntimePlatform);
            }
        }));

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
            AbilityManager.StrengthScore = PointStr;
            AbilityManager.DexterityScore = PointDex;
            AbilityManager.ConstitutionScore = PointCon;
            AbilityManager.IntelligenceScore = PointInt;
            AbilityManager.WisdomScore = PointWis;
            AbilityManager.CharismaScore = PointCha;
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
    }
}
