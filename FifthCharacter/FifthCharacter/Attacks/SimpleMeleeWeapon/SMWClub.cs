using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using FifthCharacter.Attacks.Mechanics.Property;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.SimpleMeleeWeapon {
    public class SMWClub : ASimpleMeleeWeapon {
        public override string Name => "Club";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d4";
        public override string DamageType => "Bludgeoning";

        public override string Cost => "1sp";
        public override string Weight => "2lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight()
        };
    }
}
