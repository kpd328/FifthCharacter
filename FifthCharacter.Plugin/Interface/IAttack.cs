using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace FifthCharacter.Plugin.Interface {
    public interface IAttack {
        string Name { get; }
        string ID { get; }
        string AttackBonus { get; }
        string DamageDice { get; }
        string DamageType { get; }
        string Range { get; }

        ICommand Popup { get; }

        IAttack GetInstance();
    }
}
