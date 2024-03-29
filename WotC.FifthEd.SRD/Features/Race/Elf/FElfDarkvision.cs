﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Elf {
    public class FElfDarkvision : IFeature {
        public string Name => "Darkvision";
        public string ID => "SRD.Feature.Race.Elf.Darkvision";
        public string Source => "Race Elf";
        public string Text => RacialFeatures.Darkvision_Elf;
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

        public IFeature GetInstance() => new FElfDarkvision();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
