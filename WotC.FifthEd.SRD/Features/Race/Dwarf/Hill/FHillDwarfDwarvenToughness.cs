using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Dwarf.Hill {
    public class FHillDwarfDwarvenToughness : IFeature {
        public string Name => "Dwarven Toughness";
        public string ID => "SRD.Feature.Race.Dwarf.Hill.DwarvenToughness";
        public string Source => "Race Dwarf (Hill Dwarf)";
        public string Text => RacialFeatures.Dwarven_Toughness;
        public bool IsActive => false;
        public int ActiveUses => 0;

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

        public IFeature GetInstance() => new FHillDwarfDwarvenToughness();
    }
}
