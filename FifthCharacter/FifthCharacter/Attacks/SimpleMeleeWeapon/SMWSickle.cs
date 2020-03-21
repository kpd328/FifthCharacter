using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.SimpleMeleeWeapon {
    public class SMWSickle : ASimpleMeleeWeapon {
        public override string Name => "Sickle";

        public override string AttackBonus { get; set; }

        public override string DamageDice => "1d4";

        public override string DamageType => "Slashing";

        public override string Cost => "1 gp";

        public override string Weight => "2 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight()
        };
    }
}
