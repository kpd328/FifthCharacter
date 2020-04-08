using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWHandCrossbow : AMartialRangedWeapon {
        public override string Name => "Hand Crossbow";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d6";

        public override string DamageType => "Piercing";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "75 gp";

        public override string Weight => "3 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
