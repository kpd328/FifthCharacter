using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Abstract {
    public abstract class AMartialWeapon : IAttack {
        public abstract string Name { get; }
        public abstract string AttackBonus { get; }
        public abstract string DamageDice { get; }
        public abstract string DamageType { get; }
        public abstract string Range { get; }

        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract IList<IWeaponProperty> Properties { get; }
    }
}
