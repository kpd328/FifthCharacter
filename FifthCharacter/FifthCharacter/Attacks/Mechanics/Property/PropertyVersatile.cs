using FifthCharacter.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyVersatile : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Versatile;
        public string PropertyName => WeapPropName.Versatile;
        private Dice Dice { get; set; }
        public string Die => Dice.ToString;

        public PropertyVersatile(Dice die) {
            Dice = die;
        }

        public PropertyVersatile(int num, int die) {
            Dice = new Dice(num, die);
        }
    }
}
