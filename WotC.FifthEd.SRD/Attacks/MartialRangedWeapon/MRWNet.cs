﻿using FifthCharacter.Plugin.Interface;
using System;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Attacks.Abstract;
using WotC.FifthEd.SRD.Attacks.Mechanics;

namespace WotC.FifthEd.SRD.Attacks.MartialRangedWeapon {
    public class MRWNet : AMartialRangedWeapon {
        public override string Name => "Net";

        public override string AttackBonus => throw new NotImplementedException();

        public override string DamageDice => "-";

        public override string DamageType => "-";

        public override string Range => throw new NotImplementedException();

        public override string Cost => "1 gp";

        public override string Weight => "3 lb.";

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();

        public override IAttack GetInstance() => new MRWNet();
    }
}
