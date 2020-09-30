using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWGreatclub : ASimpleMeleeWeapon {
        public override string Name => "Greatclub";
        public override string DamageDice => "1d8";
        public override string DamageType => "Bludgeoning";
        public override ACurrency Cost => new SilverPiece(2);
        public override string Weight => "10 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new SMWGreatclub();
    }
}
