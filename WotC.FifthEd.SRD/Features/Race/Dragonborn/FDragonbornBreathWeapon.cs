using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using WotC.FifthEd.SRD.Race;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Dragonborn {
    class FDragonbornBreathWeapon : IFeature {
        public string Name => "Breath Weapon";
        public string ID => "SRD.Feature.Race.Dragonborn.BreathWeapon";
        public string Source => "Race Dragonborn";
        public string Text => Ancestry switch {
            DraconicAncestry.BLACK => RacialFeatures.Breath_Weapon_Black,
            DraconicAncestry.BLUE => RacialFeatures.Breath_Weapon_Blue,
            DraconicAncestry.BRASS => RacialFeatures.Breath_Weapon_Brass,
            DraconicAncestry.BRONZE => RacialFeatures.Breath_Weapon_Bronze,
            DraconicAncestry.COPPER => RacialFeatures.Breath_Weapon_Copper,
            DraconicAncestry.GOLD => RacialFeatures.Breath_Weapon_Gold,
            DraconicAncestry.GREEN => RacialFeatures.Breath_Weapon_Green,
            DraconicAncestry.RED => RacialFeatures.Breath_Weapon_Red,
            DraconicAncestry.SILVER => RacialFeatures.Breath_Weapon_Silver,
            DraconicAncestry.WHITE => RacialFeatures.Breath_Weapon_White,
            _ => RacialFeatures.Breath_Weapon,
        };
        public bool IsActive => true;
        public int ActiveUses => 1;
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

        internal FDragonbornBreathWeapon() { }

        public FDragonbornBreathWeapon(DraconicAncestry ancestry) => Ancestry = ancestry;

        public IFeature GetInstance() => new FDragonbornBreathWeapon();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
