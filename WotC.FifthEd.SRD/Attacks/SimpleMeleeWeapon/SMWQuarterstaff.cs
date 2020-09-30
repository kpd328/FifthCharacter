using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWQuarterstaff : ASimpleMeleeWeapon {
        public override string Name => "Quarterstaff";
        public override string DamageDice => "1d6";
        public override string DamageType => "Bludgeoning";
        public override ACurrency Cost => new SilverPiece(2);
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyVersatile(1,8)
        };

        public override IAttack GetInstance() => new SMWQuarterstaff();
    }
}
