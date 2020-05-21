using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Feat {
    public abstract class AFeat : IFeature {
        public abstract string Name { get; }
        public abstract string ID { get; }
        public abstract string Source { get; set; }
        public abstract string Text { get; }
        public abstract bool IsActive { get; }
        public abstract int ActiveUses { get; }
        public abstract bool IsAbilityMod { get; }
        
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

        public abstract IFeature GetInstance();
        public abstract void ModAbility();
        public abstract bool MeetsPrerequisite();
    }
}
