﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Abstract {
    public abstract class ASpellAttack : IAttack, IMagic {
        public string Name { get; protected set; }
        public string AttackBonus { get; protected set; }
        public string DamageDice { get; protected set; }
        public string DamageType { get; protected set; }
        public string Range { get; protected set; }
    }
}