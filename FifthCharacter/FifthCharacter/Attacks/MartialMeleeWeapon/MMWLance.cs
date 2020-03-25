﻿using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using FifthCharacter.Attacks.Mechanics.Property.Special;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWLance : AMartialMeleeWeapon {
        public override string Name => "Lance";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d12";

        public override string DamageType => "Piercing";

        public override string Cost => "10 gp";

        public override string Weight => "6 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyReach(),
            new PropertySpecialLance()
        };
    }
}
