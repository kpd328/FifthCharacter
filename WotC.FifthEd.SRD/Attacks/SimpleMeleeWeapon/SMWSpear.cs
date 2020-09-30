﻿using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWSpear : ASimpleMeleeWeapon {
        public override string Name => "Spear";
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new GoldPiece(1);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyThrown(20,60), new PropertyVersatile(1,8)
        };

        public override IAttack GetInstance() => new SMWSpear();
    }
}
