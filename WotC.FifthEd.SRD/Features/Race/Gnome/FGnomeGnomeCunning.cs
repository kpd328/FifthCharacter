﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Gnome {
    public class FGnomeGnomeCunning : IFeature {
        public string Name => "Gnome Cunning";
        public string ID => "SRD.Feature.Race.Gnome.GnomeCunning";
        public string Source => "Race Gnome";
        public string Text => RacialFeatures.Gnome_Cunning;
        public bool IsActive => false;
        public int ActiveUses => 0;
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

        public IFeature GetInstance() => new FGnomeGnomeCunning();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
