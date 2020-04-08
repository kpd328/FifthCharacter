using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWHeavyCrossbow : AMartialRangedWeapon {
        public override string Name => "Heavy Crossbow";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d10";
        public override string DamageType => "Piercing";
        public override string Range => "100/400 ft";
        public override string Cost => "50 gp";
        public override string Weight => "18 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(100, 400),
            new PropertyHeavy(),
            new PropertyLoading(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MRWHeavyCrossbow();
    }
}
