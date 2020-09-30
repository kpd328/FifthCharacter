using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWGlaive : AMartialMeleeWeapon {
        public override string Name => "Glaive";
        public override string DamageDice => "1d10";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(20);
        public override string Weight => "6 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyReach(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWGlaive();
    }
}
