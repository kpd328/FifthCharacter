using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyReach : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Reach;
        public string PropertyName => WeapPropName.Reach;
    }
}
