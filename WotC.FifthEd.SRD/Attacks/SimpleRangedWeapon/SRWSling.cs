using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWSling : ASimpleRangedWeapon {
        public override string Name => "Sling";
        public override string DamageDice => "1d4";
        public override string DamageType => "Bludgeoning";
        public override string Range => "30/120 ft";
        public override ACurrency Cost => new SilverPiece(1);
        public override string Weight => "-";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(30, 120)
        };

        public override IAttack GetInstance() => new SRWSling();
    }
}
