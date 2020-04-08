﻿using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWHeavyCrossbow : AMartialRangedWeapon {
        public override string Name => "Heavy Crossbow";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "1d10";

        public override string DamageType => "Piercing";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "50 gp";

        public override string Weight => "18 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();

        public override IAttack GetInstance() => new MRWHeavyCrossbow();
    }
}