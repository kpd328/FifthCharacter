using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWHalberd : AMartialMeleeWeapon {
        public override string Name => "Halberd";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d10";

        public override string DamageType => "Slashing";

        public override string Cost => "20 gp";

        public override string Weight => "6 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };
    }
}
