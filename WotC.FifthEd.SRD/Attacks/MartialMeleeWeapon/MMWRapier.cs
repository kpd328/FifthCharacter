using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWRapier : AMartialMeleeWeapon {
        public override string Name => "Rapier";
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new GoldPiece(25);
        public override string Weight => "18 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyFinesse(),
        };

        public override IAttack GetInstance() => new MMWRapier();
    }
}
