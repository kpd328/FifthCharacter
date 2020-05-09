using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Tiefling {
    public class FTieflingInfernalLegacy5th : IFeature {
        public string Name => "Infernal Legacy";
        public string ID => "SRD.Feature.Race.Tiefling.InfernalLegacy.5th";
        public string Source => "Race Tiefling";
        public string Text => RacialFeatures.Infernal_Legacy_5th;
        public bool IsActive => true;
        public int ActiveUses => 1; //TODO: this one's weird, theres 1 5th and 1 3rd usage, will need to find a way to integrate them as one entry with two seperate usages
        public bool IsAbilityMod => false;

        private ICommand _popup;
        public ICommand Popup => _popup ?? (_popup = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PushAsync(new PopupFeature(this));
                    break;
                case Device.GTK:
                    DependencyService.Get<IPopup>().PushAsync(new PopupFeature_GTK(this));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }));

        public IFeature GetInstance() => new FTieflingInfernalLegacy5th();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
