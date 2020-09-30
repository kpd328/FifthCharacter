using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWWarPick : AMartialMeleeWeapon {
        public override string Name => "War Pick";
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new GoldPiece(5);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new MMWWarPick();
    }
}
