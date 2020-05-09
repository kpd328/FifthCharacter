using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.HalfOrc {
    public class FHalfOrcRelentlessEndurance : IFeature {
        public string Name => "Relentless Endurance";
        public string ID => "SRD.Feature.Race.HalfOrc.RelentlessEndurance";
        public string Source => "Race Half-Orc";
        public string Text => RacialFeatures.Relentless_Endurance;
        public bool IsActive => true;
        public int ActiveUses => 1;
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

        public IFeature GetInstance() => new FHalfOrcRelentlessEndurance();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
