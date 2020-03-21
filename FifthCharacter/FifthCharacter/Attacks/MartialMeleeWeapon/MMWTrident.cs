using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
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
    }
}
