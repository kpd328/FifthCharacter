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
        public override SpellLevel SpellLevel => SpellLevel.SECOND_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 action";
        public override string Range => "90 feet";
        public override IList<string> Components => new List<string>() { 
            "V",
            "S",
            "M (powdered rhubarb leaf and an adder's stomach)"
        };
        public override string Duration => "Instantaneous";
        public override string Targets => "A target within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Acid Arrow";

        public string AttackBonus { get; }
        public string DamageDice => "4d4";
        public string DamageType => "Acid";
        public string WeaponType => "Ranged Spell Attack";

        private ICommand _addAttack;
        public ICommand AddAttack => _addAttack ?? (_addAttack = new Command(() => {
            PopupNavigation.Instance.PopAsync();
        }));

        public IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override string Description => SpellDescriptions.AcidArrow;
        public new string AtHigherLevels => AtHigherLevelsDescriptions.AcidArrow;

        public override IMagic GetInstance() => new AcidArrow();
        IAttack IAttack.GetInstance() => new AcidArrow();
    }
}
