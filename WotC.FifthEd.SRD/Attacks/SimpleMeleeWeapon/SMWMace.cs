using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWMace : ASimpleMeleeWeapon {
        public override string Name => "Mace";
        public override string DamageDice => "1d6";
        public override string DamageType => "Blugeoning";
        public override ACurrency Cost => new GoldPiece(5);
        public override string Weight => "4 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new SMWMace();
    }
}
