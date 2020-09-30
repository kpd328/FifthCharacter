using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWLongbow : AMartialRangedWeapon {
        public override string Name => "Longbow";
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override string Range => "150/600 ft";
        public override ACurrency Cost => new GoldPiece(50);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(150, 600),
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MRWLongbow();
    }
}
