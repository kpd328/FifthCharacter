using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialMeleeWeapon {
    public class MMWWarPick : AMartialMeleeWeapon {
        public override string Name => "War Pick";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d8";

        public override string DamageType => "Piercing";

        public override string Cost => "5 gp";

        public override string Weight => "2 lb.";

        public override IList<IWeaponProperty> Properties => new List<IWeaponProperty>();

        public override IAttack GetInstance() => new MMWWarPick();
    }
}
