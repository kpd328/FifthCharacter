using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWSling : ASimpleRangedWeapon {
        public override string Name => throw new NotImplementedException();

        public override string AttackBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string DamageDice => throw new NotImplementedException();

        public override string DamageType => throw new NotImplementedException();

        public override string Range => throw new NotImplementedException();

        public override string Cost => throw new NotImplementedException();

        public override string Weight => throw new NotImplementedException();

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
