﻿using FifthCharacter.Plugin.Interface;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Halfling.Lightfoot {
    public class FLightfootHalflingNaturallyStealthy : IFeature {
        public string Name => "Naturally Stealthy";
        public string ID => "SRD.Feature.Race.Halfling.Lightfoot.NaturallyStealthy";
        public string Source => "Race Halfling (Lightfoot)";
        public string Text => RacialFeatures.Naturally_Stealthy;
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

        public IFeature GetInstance() => new FLightfootHalflingNaturallyStealthy();

        public void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
    }
}
