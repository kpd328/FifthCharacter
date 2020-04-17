using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWDart : ASimpleRangedWeapon {
        public override string Name => "Dart";
        public override string DamageDice => "1d4";
        public override string DamageType => "Piercing";
        public override string Range => "20/60 ft";
        public override string Cost => "5 cp";
        public override string Weight => "1/4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyThrown(20, 60)
        };

        public override IAttack GetInstance() => new SRWDart();
    }
}
