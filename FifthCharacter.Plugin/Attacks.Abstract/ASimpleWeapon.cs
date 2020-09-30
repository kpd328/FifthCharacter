using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.StatsManager;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class ASimpleWeapon : IAttack, IEquipment {
        public abstract string Name { get; }
        public string ID => string.Format("{0}.{1}", GetType().Name, Name);
        public abstract string AttackBonus { get; }
        public abstract string DamageDice { get; }
        public abstract string DamageType { get; }
        public abstract string Range { get; }

        public abstract ACurrency Cost { get; }
        public abstract string Weight { get; }
        public abstract string WeaponType { get; }
        public abstract IList<IWeaponProperty> Properties { get; }

        private ICommand _popup;
        public ICommand Popup => _popup ?? (_popup = new Command(() => {
            switch (Device.RuntimePlatform) {
                case Device.UWP:
                case Device.iOS:
                case Device.Android:
                    PopupNavigation.Instance.PushAsync(new PopupAttack(this));
                    break;
                case Device.GTK:
                    DependencyService.Get<IPopup>().PushAsync(new PopupAttack_GTK(this));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }));

        private ICommand _addAttack;
        public ICommand AddAttack => _addAttack ?? (_addAttack = new Command(() => {
            AttacksManager.Attacks.Add(this);
            PopupNavigation.Instance.PopAsync();
        }));

        public virtual string Description => "";
        public int Count { get; set; }

        public abstract IAttack GetInstance();
    }
}
