using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWBlowgun : AMartialRangedWeapon {
        public override string Name => "Blowgun";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d1";

        public override string DamageType => "Piercing";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "10 gp";

        public override string Weight => "1 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
