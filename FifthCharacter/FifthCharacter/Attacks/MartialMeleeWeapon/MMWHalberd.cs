using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWHalberd : AMartialMeleeWeapon {
        public override string Name => "Halberd";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d10";

        public override string DamageType => "Slashing";

        public override string Cost => "20 gp";

        public override string Weight => "6 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };
    }
}
