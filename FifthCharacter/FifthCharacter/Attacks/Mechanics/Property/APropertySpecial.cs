using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public abstract class APropertySpecial : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Special;
    }
}
