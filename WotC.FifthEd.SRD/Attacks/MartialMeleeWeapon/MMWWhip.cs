using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWWhip : AMartialMeleeWeapon {
        public override string Name => "Whip";
        public override string DamageDice => "1d4";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(2);
        public override string Weight => "3 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
            new PropertyReach()
        };

        public override IAttack GetInstance() => new MMWWhip();
    }
}
