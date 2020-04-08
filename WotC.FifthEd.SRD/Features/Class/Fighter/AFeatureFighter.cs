using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Class.Fighter {
    public abstract class AFeatureFighter : IFeature {
        public abstract string Name { get; }
        public string Source => "Class Fighter";
        public abstract string Text { get; }
        public abstract bool IsActive { get; }
        public abstract int ActiveUses { get; }

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

        public string ID => string.Format("{0}.{1}.{2}", SRD5.Name, GetType().Name, Name);

        public abstract IFeature GetInstance();
    }
}
