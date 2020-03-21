using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialRangedWeapon {
    public class MRWNet : AMartialRangedWeapon {
        public override string Name => "Net";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "-";

        public override string DamageType => "-";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "1 gp";

        public override string Weight => "3 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
