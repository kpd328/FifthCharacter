﻿using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWHandCrossbow : AMartialRangedWeapon {
        public override string Name => "Hand Crossbow";
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Range => "30/120 ft";
        public override ACurrency Cost => new GoldPiece(75);
        public override string Weight => "3 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(30, 120),
            new PropertyLight(),
            new PropertyLoading()
        };

        public override IAttack GetInstance() => new MRWHandCrossbow();
    }
}
