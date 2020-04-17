using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleMeleeWeapon {
    public class SMWLightHammer : ASimpleMeleeWeapon {
        public override string Name => "Light Hammer";
        public override string DamageDice => "1d4";
        public override string DamageType => "Bludgeoning";
        public override string Cost => "2 gp";
        public override string Weight => "2 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyLight(), new PropertyThrown(20,60)
        };

        public override IAttack GetInstance() => new SMWLightHammer();
    }
}
