﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public abstract class AFeatureDruid : IFeature {
        public abstract string Name { get; }
        public virtual string ID => string.Format("SRD.Feature.Class.Druid.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z:.]+", "").Replace(':', '.'));
        public virtual string Source => "Class Druid";
        public abstract string Text { get; }
        public abstract bool IsActive { get; }
        public abstract int ActiveUses { get; }
        public virtual bool IsAbilityMod => false;

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

        public abstract IFeature GetInstance();
        public virtual void ModAbility() => throw new NotImplementedException("IsAbilityMod is false, this method is invalid.");
    }
}
