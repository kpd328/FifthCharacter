using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property.Special;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWNet : AMartialRangedWeapon {
        public override string Name => "Net";
        public override string DamageDice => "-";
        public override string DamageType => "-";
        public override string Range => "5/15 ft";
        public override ACurrency Cost => new GoldPiece(1);
        public override string Weight => "3 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertySpecialNet(),
            new PropertyThrown(5, 15)
        };

        public override IAttack GetInstance() => new MRWNet();
    }
}
