using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWGreataxe : AMartialMeleeWeapon {
        public override string Name => "Greataxe";
        public override string DamageDice => "1d12";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(30);
        public override string Weight => "7 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyHeavy(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new MMWGreataxe();
    }
}
