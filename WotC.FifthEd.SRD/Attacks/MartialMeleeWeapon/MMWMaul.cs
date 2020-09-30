using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWMaul : AMartialMeleeWeapon {
        public override string Name => "Maul";
        public override string DamageDice => "2d6";
        public override string DamageType => "Bludgeoning";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "10 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWMaul();
    }
}
