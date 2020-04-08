using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;

namespace FifthCharacter.Plugin.Attacks.Abstract {
    public abstract class ASimpleWeapon : IAttack {
        public abstract string Name { get; }
        public string ID => string.Format("{0}.{1}", GetType().Name, Name);
        public abstract string AttackBonus { get; set; }
        public abstract string DamageDice { get; }
        public abstract string DamageType { get; }
        public abstract string Range { get; }

        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract IList<IWeaponProperty> Properties { get; }

        public abstract IAttack GetInstance();
    }
}
