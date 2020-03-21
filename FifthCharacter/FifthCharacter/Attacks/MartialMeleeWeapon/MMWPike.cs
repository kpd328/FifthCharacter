using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWPike : AMartialMeleeWeapon {
        public override string Name => "Pike";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d10";

        public override string DamageType => "Piercing";

        public override string Cost => "5 gp";

        public override string Weight => "18 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };
    }
}
