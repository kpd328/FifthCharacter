using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;
using WotC.FifthEd.SRD.Attacks.Mechanics.Property;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWLongsword : AMartialMeleeWeapon {
        public override string Name => "Longsword";
        public override string AttackBonus { get; }
        public override string DamageDice => "1d8";
        public override string DamageType => "Slashing";
        public override string Cost => "15 gp";
        public override string Weight => "3 lb.";
        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>() {
            new PropertyVersatile(1,10)
        };

        public override IAttack GetInstance() => new MMWLongsword();
    }
}
