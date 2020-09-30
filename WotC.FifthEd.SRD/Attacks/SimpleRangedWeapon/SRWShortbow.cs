using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWShortbow : ASimpleRangedWeapon {
        public override string Name => "Shortbow";
        public override string DamageDice => "1d6";
        public override string DamageType => "Piercing";
        public override string Range => "80/320 ft";
        public override ACurrency Cost => new GoldPiece(25);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(80, 320),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new SRWShortbow();
    }
}
