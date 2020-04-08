using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWShortsword : AMartialMeleeWeapon {
        public override string Name => "Shortsword";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Cost => "10 gp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyLight()
        };

        public override IAttack GetInstance() => new MMWShortsword();
    }
}
