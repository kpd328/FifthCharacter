﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Elf.High {
    public class FHighElfAbilityScoreIncrease : IFeature {
        public string Name => "Ability Score Increase";
        public string ID => "SRD.Feature.Race.Elf.High.AbilityScoreIncrease";
        public string Source => "Race Elf (High)";
        public string Text => RacialFeatures.Ability_Score_Increase_High_Elf;
        public bool IsActive => false;
        public int ActiveUses => 0;
        public bool IsAbilityMod => true;

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

        public IFeature GetInstance() => new FHighElfAbilityScoreIncrease();

        public void ModAbility() => AbilityManager.IntelligenceScore += 1;
    }
}