using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWClub : ASimpleMeleeWeapon {
        public override string Name => "Club";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d4";
        public override string DamageType => "Bludgeoning";
        public override string Cost => "1 sp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight()
        };

        public override IAttack GetInstance() => new SMWClub();
    }
}
