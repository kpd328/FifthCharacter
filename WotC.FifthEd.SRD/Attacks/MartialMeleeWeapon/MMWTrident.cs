using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWTrident : AMartialMeleeWeapon {
        public override string Name => "Trident";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d6";

        public override string DamageType => "Piercing";

        public override string Cost => "5 gp";

        public override string Weight => "4 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyThrown(20,60),
            new PropertyVersatile(1,8)
        };

        public override IAttack GetInstance() => new MMWTrident();
    }
}
