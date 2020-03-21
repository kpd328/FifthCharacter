using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.SimpleMeleeWeapon {
    public class SMWMace : ASimpleMeleeWeapon {
        public override string Name => "Mace";

        public override string AttackBonus { get; set; }

        public override string DamageDice => "1d6";

        public override string DamageType => "Blugeoning";

        public override string Cost => "5 gp";

        public override string Weight => "4 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();
    }
}
