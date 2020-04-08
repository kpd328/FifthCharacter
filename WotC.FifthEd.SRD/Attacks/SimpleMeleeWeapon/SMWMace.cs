using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWMace : ASimpleMeleeWeapon {
        public override string Name => "Mace";
        public override string AttackBonus { get; set; }
        public override string DamageDice => "1d6";
        public override string DamageType => "Blugeoning";
        public override string Cost => "5 gp";
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new SMWMace();
    }
}
