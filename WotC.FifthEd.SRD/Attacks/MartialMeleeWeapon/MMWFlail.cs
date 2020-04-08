using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWFlail : AMartialMeleeWeapon {
        public override string Name => "Flail";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d8";
        public override string DamageType => "Bludgeoning";
        public override string Cost => "10 gp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new MMWFlail();
    }
}
