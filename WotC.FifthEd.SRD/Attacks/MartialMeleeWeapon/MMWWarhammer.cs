using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWWarhammer : AMartialMeleeWeapon {
        public override string Name => "Warhammer";
        public override string DamageDice => "1d8";
        public override string DamageType => "Bludgeoning";
        public override ACurrency Cost => new GoldPiece(15);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyVersatile(1,10)
        };

        public override IAttack GetInstance() => new MMWWarhammer();
    }
}
