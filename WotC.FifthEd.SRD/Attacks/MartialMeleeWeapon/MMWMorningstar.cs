﻿using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWMorningstar : AMartialMeleeWeapon {
        public override string Name => "Morningstar";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override string Cost => "15 gp";
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new MMWMorningstar();
    }
}
