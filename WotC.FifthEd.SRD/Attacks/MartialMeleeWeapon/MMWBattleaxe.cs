using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWBattleaxe : AMartialMeleeWeapon {
        public override string Name => "Battleaxe";
        public override string DamageDice => "1d8";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyVersatile(1,10)
        };

        public override IAttack GetInstance() => new MMWBattleaxe();
    }
}
