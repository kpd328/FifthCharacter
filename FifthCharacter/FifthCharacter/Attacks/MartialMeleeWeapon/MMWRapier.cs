﻿using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWRapier : AMartialMeleeWeapon {
        public override string Name => "Rapier";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d8";

        public override string DamageType => "Piercing";

        public override string Cost => "25 gp";

        public override string Weight => "18 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
        };
    }
}
