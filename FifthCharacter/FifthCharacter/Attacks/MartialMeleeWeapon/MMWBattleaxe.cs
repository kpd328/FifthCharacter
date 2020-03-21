using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.MartialMeleeWeapon {
    public class MMWBattleaxe : AMartialMeleeWeapon {
        public override string Name => "Battleaxe";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d8";

        public override string DamageType => "Slashing";

        public override string Cost => "10 gp";

        public override string Weight => "4 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyVersatile(1,10)
        };
    }
}
