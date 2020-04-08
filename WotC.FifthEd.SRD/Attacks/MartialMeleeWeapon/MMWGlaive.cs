using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWGlaive : AMartialMeleeWeapon {
        public override string Name => "Glaive";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d10";
        public override string DamageType => throw new NotImplementedException();
        public override string Cost => "20 gp";
        public override string Weight => "6 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWGlaive();
    }
}
