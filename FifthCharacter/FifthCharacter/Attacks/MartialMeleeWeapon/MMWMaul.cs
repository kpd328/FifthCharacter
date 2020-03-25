using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWMaul : AMartialMeleeWeapon {
        public override string Name => "Maul";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "2d6";

        public override string DamageType => "Bludgeoning";

        public override string Cost => "10 gp";

        public override string Weight => "10 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };
    }
}
