using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics {
    public interface IWeaponProperty {
        string PropertyName { get; }
        string TextDescription { get; }
    }
}
