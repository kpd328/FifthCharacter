using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWHandCrossbow : AMartialRangedWeapon {
        public override string Name => "Hand Crossbow";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Range => "30/120 ft";
        public override string Cost => "75 gp";
        public override string Weight => "3 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(30, 120),
            new PropertyLight(),
            new PropertyLoading()
        };

        public override IAttack GetInstance() => new MRWHandCrossbow();
    }
}
