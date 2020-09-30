﻿using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWMorningstar : AMartialMeleeWeapon {
        public override string Name => "Morningstar";
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new GoldPiece(15);
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new MMWMorningstar();
    }
}
