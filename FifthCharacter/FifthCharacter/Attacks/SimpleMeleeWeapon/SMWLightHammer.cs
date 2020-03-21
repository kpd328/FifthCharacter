using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.SimpleMeleeWeapon {
    public class SMWLightHammer : ASimpleMeleeWeapon {
        public override string Name => "Light Hammer";

        public override string AttackBonus { get; set; }

        public override string DamageDice => "1d4";

        public override string DamageType => "Bludgeoning";

        public override string Cost => "2 gp";

        public override string Weight => "2 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyLight(), new PropertyThrown(20,60)
        };
    }
}
