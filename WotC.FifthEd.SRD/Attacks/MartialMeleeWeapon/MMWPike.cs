using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWPike : AMartialMeleeWeapon {
        public override string Name => "Pike";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d10";
        public override string DamageType => "Piercing";
        public override string Cost => "5 gp";
        public override string Weight => "18 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWPike();
    }
}
