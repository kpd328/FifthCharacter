using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Equipment.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;
using WotC.FifthEd.SRD.Equipment.Currency;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWHandaxe : ASimpleMeleeWeapon {
        public override string Name => "Handaxe";
        public override string DamageDice => "1d6";
        public override string DamageType => "Slashing";
        public override ACurrency Cost => new GoldPiece(5);
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight(), new PropertyThrown(20,60)
        };

        public override IAttack GetInstance() => new SMWHandaxe();
    }
}
