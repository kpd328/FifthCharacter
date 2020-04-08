using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.Abstract {
    public abstract class AMartialWeapon : IAttack {
        public abstract string Name { get; }
        public string ID => string.Format("{0}.{1}.{2}", SRD5.Name, GetType().Name, Name);
        public abstract string AttackBonus { get; }
        public abstract string DamageDice { get; }
        public abstract string DamageType { get; }
        public abstract string Range { get; }

        public abstract string Cost { get; }
        public abstract string Weight { get; }
        public abstract IList<IWeaponProperty> Properties { get; }

        public abstract IAttack GetInstance();
    }
}
