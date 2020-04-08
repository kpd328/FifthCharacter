using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWGreatsword : AMartialMeleeWeapon {
        public override string Name => "Greatsword";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "2d6";

        public override string DamageType => "Slashing";

        public override string Cost => "50 gp";

        public override string Weight => "6 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWGreatsword();
    }
}
