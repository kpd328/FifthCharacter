using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWJavelin : ASimpleMeleeWeapon {
        public override string Name => "Javelin";
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new SilverPiece(5);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyThrown(30,120)
        };

        public override IAttack GetInstance() => new SMWJavelin();
    }
}
