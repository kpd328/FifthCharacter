using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWBlowgun : AMartialRangedWeapon {
        public override string Name => "Blowgun";
        public override string DamageDice => "1d1";
        public override string DamageType => "Piercing";
        public override string Range => "25/100 ft";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "1 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(25, 100),
            new PropertyLoading()
        };

        public override IAttack GetInstance() => new MRWBlowgun();
    }
}
