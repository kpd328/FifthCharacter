﻿using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWScimitar : AMartialMeleeWeapon {
        public override string Name => "Scimitar";
        public override string DamageDice => "1d6";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(25);
        public override string Weight => "18 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyLight()
        };

        public override IAttack GetInstance() => new MMWScimitar();
    }
}
