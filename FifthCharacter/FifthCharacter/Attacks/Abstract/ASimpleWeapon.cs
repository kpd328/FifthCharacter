using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;

namespace FifthCharacter.Attacks.Abstract {
    public abstract class ASimpleWeapon : IAttack {
        public abstract string Name { get; }
        public abstract string AttackBonus { get; set; }
        public abstract string DamageDice { get; }
        public abstract string DamageType { get; }
        public abstract string Range { get; }

        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract IList<IWeaponProperty> Properties { get; }
    }
}
