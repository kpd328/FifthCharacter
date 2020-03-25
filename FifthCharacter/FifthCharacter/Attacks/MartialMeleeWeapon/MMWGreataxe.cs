using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWGreataxe : AMartialMeleeWeapon {
        public override string Name => "Greataxe";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d12";

        public override string DamageType => "Slashing";

        public override string Cost => "30 gp";

        public override string Weight => "7 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };
    }
}
