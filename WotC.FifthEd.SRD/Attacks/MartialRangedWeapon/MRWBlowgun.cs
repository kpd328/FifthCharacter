using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWBlowgun : AMartialRangedWeapon {
        public override string Name => "Blowgun";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d1";
        public override string DamageType => "Piercing";
        public override string Range => "25/100 ft";
        public override string Cost => "10 gp";
        public override string Weight => "1 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(25, 100),
            new PropertyLoading()
        };

        public override IAttack GetInstance() => new MRWBlowgun();
    }
}
