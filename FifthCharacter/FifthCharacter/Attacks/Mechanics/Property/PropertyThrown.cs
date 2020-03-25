using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyThrown : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Thrown;
        public string PropertyName => WeapPropName.Thrown;
        private int RangeOpt { get; set; }
        private int RangeMax { get; set; }
        
        public PropertyThrown(int opt, int max) {
            RangeOpt = opt;
            RangeMax = max;
        }
    }
}
