using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWShortbow : ASimpleRangedWeapon {
        public override string Name => "Shortbow";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Range => "80/320 ft";
        public override string Cost => "25 gp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(80, 320),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new SRWShortbow();
    }
}
