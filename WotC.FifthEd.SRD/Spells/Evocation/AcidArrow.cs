using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Popup;
using FifthCharacter.Plugin.Spells.Abstract;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace WotC.FifthEd.SRD.Spells.Evocation {
    public class AcidArrow : ASchoolEvocation, IRangedSpellAttack {
        public override SpellLevel SpellLevel => throw new NotImplementedException();
        public override bool Ritual => throw new NotImplementedException();
        public override string CastingTime => throw new NotImplementedException();
        public override string Range => throw new NotImplementedException();
        public override IList<string> Components => throw new NotImplementedException();
        public override string Duration => throw new NotImplementedException();
        public override string Targets => throw new NotImplementedException();
        public override string AreaOfEffect => throw new NotImplementedException();
        public override string Name => throw new NotImplementedException();

        public string AttackBonus { get; }
        public string DamageDice => throw new NotImplementedException();
        public string DamageType => throw new NotImplementedException();

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

        public override IMagic GetInstance() => new AcidArrow();

        IAttack IAttack.GetInstance() => new AcidArrow();
    }
}
