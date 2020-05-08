﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using WotC.FifthEd.SRD.Popup;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.Race.Dwarf.Hill {
    public class FHillDwarfAbilityScoreIncrease : IFeature {
        public string Name => "Ability Score Increase";
        public string ID => "SRD.Feature.Race.Dwarf.Hill.AbilityScoreIncrease";
        public string Source => "Race Dwarf (Hill)";
        public string Text => RacialFeatures.Ability_Score_Increase_Hill_Dwarf;
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

        public IFeature GetInstance() => new FHillDwarfAbilityScoreIncrease();
        public void ModAbility() => AbilityManager.WisdomScore += 1;
    }
}
