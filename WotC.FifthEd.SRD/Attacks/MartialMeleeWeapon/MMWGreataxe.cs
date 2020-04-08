using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWGreataxe : AMartialMeleeWeapon {
        public override string Name => "Greataxe";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d12";
        public override string DamageType => "Slashing";
        public override string Cost => "30 gp";
        public override string Weight => "7 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWGreataxe();
    }
}
