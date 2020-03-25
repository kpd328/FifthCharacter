using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyLoading : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Loading;
        public string PropertyName => WeapPropName.Loading;
    }
}
