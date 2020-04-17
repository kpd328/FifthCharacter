using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.SimpleRangedWeapon {
    public class SRWLightCrossbow : ASimpleRangedWeapon {
        public override string Name => "Light Crossbow";
        public override string DamageDice => "1d8";
        public override string DamageType => "Piercing";
        public override string Range => "80/320 ft";
        public override string Cost => "25 gp";
        public override string Weight => "5 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyAmmunition(80, 320),
            new PropertyLoading(),
            new PropertyTwoHanded()
        };

        public override IAttack GetInstance() => new SRWLightCrossbow();
    }
}
