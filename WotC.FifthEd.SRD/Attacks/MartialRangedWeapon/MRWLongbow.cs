using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWLongbow : AMartialRangedWeapon {
        public override string Name => "Longbow";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d8";

        public override string DamageType => "Piercing";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "50 gp";

        public override string Weight => "2 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
