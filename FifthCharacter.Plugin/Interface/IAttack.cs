using FifthCharacter.Plugin.Attacks.Abstract;
using System.Collections.Generic;
using System.Windows.Input;

namespace FifthCharacter.Plugin.Interface {
    public interface IAttack {
        string Name { get; }
        string ID { get; }
        string AttackBonus { get; }
        string DamageDice { get; }
        string DamageType { get; }
        string Range { get; }
        string WeaponType { get; }
        IList<IWeaponProperty> Properties { get; }

        ICommand Popup { get; }
        ICommand AddAttack { get; }

        IAttack GetInstance();
    }
}
