using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWGreatclub : ASimpleMeleeWeapon {
        public override string Name => "Greatclub";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d8";
        public override string DamageType => "Bludgeoning";
        public override string Cost => "2 sp";
        public override string Weight => "10 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new SMWGreatclub();
    }
}
