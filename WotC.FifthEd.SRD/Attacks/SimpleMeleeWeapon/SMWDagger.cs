using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWDagger : ASimpleMeleeWeapon {
        public override string Name => "Dagger";
        public override string DamageDice => "1d4";
        public override string DamageType => "Piercing";
        public override string Cost => "2 gp";
        public override string Weight => "1 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new  PropertyLight(), new PropertyFinesse(), new PropertyThrown(20,60)
        };

        public override IAttack GetInstance() => new SMWDagger();
    }
}
