using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWRapier : AMartialMeleeWeapon {
        public override string Name => "Rapier";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d8";

        public override string DamageType => "Piercing";

        public override string Cost => "25 gp";

        public override string Weight => "18 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
        };
    }
}
