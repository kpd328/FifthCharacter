using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Race;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Dragonborn {
    public class FDragonbornDamageResistance : IFeature {
        public string Name => "Damage Resistance";
        public string ID => "SRD.Feature.Race.Dragonborn.DamageResistance";
        public string Source => "Race Dragonborn";
        public string Text => Ancestry switch {
            DraconicAncestry.BLACK => RacialFeatures.Damage_Resistance_Black,
            DraconicAncestry.BLUE => RacialFeatures.Damage_Resistance_Blue,
            DraconicAncestry.BRASS => RacialFeatures.Damage_Resistance_Brass,
            DraconicAncestry.BRONZE => RacialFeatures.Damage_Resistance_Bronze,
            DraconicAncestry.COPPER => RacialFeatures.Damage_Resistance_Copper,
            DraconicAncestry.GOLD => RacialFeatures.Damage_Resistance_Gold,
            DraconicAncestry.GREEN => RacialFeatures.Damage_Resistance_Green,
            DraconicAncestry.RED => RacialFeatures.Damage_Resistance_Red,
            DraconicAncestry.SILVER => RacialFeatures.Damage_Resistance_Silver,
            DraconicAncestry.WHITE => RacialFeatures.Damage_Resistance_White,
            _ => RacialFeatures.Damage_Resistance,
        };
        public bool IsActive => false;
        public int ActiveUses => 0;
        public bool IsAbilityMod => false;
        private DraconicAncestry Ancestry { get; set; }

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

        internal FDragonbornDamageResistance() { }

        public FDragonbornDamageResistance(DraconicAncestry ancestry) => Ancestry = ancestry;

        public IFeature GetInstance() => new FDragonbornDamageResistance();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
