using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWWhip : AMartialMeleeWeapon {
        public override string Name => "Whip";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d4";

        public override string DamageType => "Slashing";

        public override string Cost => "2 gp";

        public override string Weight => "3 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyReach()
        };

        public override IAttack GetInstance() => new MMWWhip();
    }
}
