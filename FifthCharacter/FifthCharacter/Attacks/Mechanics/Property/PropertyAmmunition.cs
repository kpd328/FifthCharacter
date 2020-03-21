﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.Mechanics.Property {
    public class PropertyAmmunition : IWeaponProperty {
        public string TextDescription => WeapPropTxt.Ammunition;
        private int RangeOpt { get; set; }
        private int RangeMax { get; set; }

        public PropertyAmmunition(int opt, int max) {
            RangeOpt = opt;
            RangeMax = max;
        }
    }
}
