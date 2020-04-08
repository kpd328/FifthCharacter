using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWScimitar : AMartialMeleeWeapon {
        public override string Name => "Scimitar";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Slashing";
        public override string Cost => "25 gp";
        public override string Weight => "18 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyLight()
        };

        public override IAttack GetInstance() => new MMWScimitar();
    }
}
