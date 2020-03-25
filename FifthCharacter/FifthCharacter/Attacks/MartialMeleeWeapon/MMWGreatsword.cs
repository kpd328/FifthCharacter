using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWGreatsword : AMartialMeleeWeapon {
        public override string Name => "Greatsword";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "2d6";

        public override string DamageType => "Slashing";

        public override string Cost => "50 gp";

        public override string Weight => "6 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };
    }
}
