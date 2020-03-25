using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyFinesse : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Finesse;
        public string PropertyName => WeapPropName.Finesse;
    }
}
