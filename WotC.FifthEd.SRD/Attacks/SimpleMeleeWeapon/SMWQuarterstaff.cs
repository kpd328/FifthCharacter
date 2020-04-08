using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWQuarterstaff : ASimpleMeleeWeapon {
        public override string Name => "Quarterstaff";

        public override string AttackBonus { get; set; }

        public override string DamageDice => "1d6";

        public override string DamageType => "Bludgeoning";

        public override string Cost => "2 sp";

        public override string Weight => "4 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyVersatile(1,8)
        };

        public override IAttack GetInstance() => new SMWQuarterstaff();
    }
}
