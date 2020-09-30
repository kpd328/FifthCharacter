using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property.Special;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWLance : AMartialMeleeWeapon {
        public override string Name => "Lance";
        public override string DamageDice => "1d12";
        public override string DamageType => "Piercing";
        public override ACurrency Cost => new GoldPiece(10);
        public override string Weight => "6 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyReach(),
            new PropertySpecialLance()
        };

        public override IAttack GetInstance() => new MMWLance();
    }
}
