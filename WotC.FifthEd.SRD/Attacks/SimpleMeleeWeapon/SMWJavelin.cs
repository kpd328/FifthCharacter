using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWJavelin : ASimpleMeleeWeapon {
        public override string Name => "Javelin";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Cost => "5 sp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyThrown(30,120)
        };

        public override IAttack GetInstance() => new SMWJavelin();
    }
}
