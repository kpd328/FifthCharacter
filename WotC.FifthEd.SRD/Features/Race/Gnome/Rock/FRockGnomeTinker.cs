﻿using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Gnome.Rock {
    public class FRockGnomeTinker : IFeature {
        public string Name => "Tinker";
        public string ID => "SRD.Feature.Race.Gnome.Rock.Tinker";
        public string Source => "Race Gnome (Tinker)";
        public string Text => RacialFeatures.Tinker;
        public bool IsActive => true; //This is active because a Rock Gnome can have 3 at a time, regaining 1 use when 1 is deactivated
        public int ActiveUses => 3; //TODO: implement system to accept regains seperate from resting
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

        public IFeature GetInstance() => new FRockGnomeTinker();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
