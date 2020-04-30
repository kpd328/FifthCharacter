using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Plugin.Spells.Abstract {
    public abstract class ASchoolTransmutation : IMagic {
        public abstract SpellLevel SpellLevel { get; }
        public abstract bool Ritual { get; }
        public abstract string CastingTime { get; }
        public abstract string Range { get; }
        public abstract IList<string> Components { get; }
        public abstract string Duration { get; }
        public abstract string Targets { get; }
        public abstract string AreaOfEffect { get; }
        public abstract string Name { get; }
        public string ID => string.Format("{0}.{1}", GetType().Name, Name);

        private ICommand _popup;
        public ICommand Popup => _popup ?? (_popup = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PushAsync(new PopupSpell(this));
                    break;
                case Device.GTK:
                    DependencyService.Get<IPopup>().PushAsync(new PopupSpell_GTK(this));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }));

        public abstract string Description { get; }
        public string AtHigherLevels => "";

        public abstract IMagic GetInstance();
    }
}
