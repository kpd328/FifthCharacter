using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWScimitar : AMartialMeleeWeapon {
        public override string Name => "Scimitar";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d6";

        public override string DamageType => "Slashing";

        public override string Cost => "25 gp";

        public override string Weight => "18 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyLight()
        };
    }
}
