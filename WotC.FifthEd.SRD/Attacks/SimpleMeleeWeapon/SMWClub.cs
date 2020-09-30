using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWClub : ASimpleMeleeWeapon {
        public override string Name => "Club";
        public override string DamageDice => "1d4";
        public override string DamageType => "Bludgeoning";
        public override ACurrency Cost => new SilverPiece(1);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight()
        };

        public override IAttack GetInstance() => new SMWClub();
    }
}
