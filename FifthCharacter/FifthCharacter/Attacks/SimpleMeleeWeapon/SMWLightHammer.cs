using FifthCharacter.Attacks.Abstract;
using FifthCharacter.Attacks.Mechanics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Attacks.SimpleMeleeWeapon {
    public class SMWLightHammer : ASimpleMeleeWeapon {
        public override string Name => throw new NotImplementedException();

        public override string AttackBonus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string DamageDice => throw new NotImplementedException();

        public override string DamageType => throw new NotImplementedException();

        public override string Cost => throw new NotImplementedException();

        public override string Weight => throw new NotImplementedException();

        public override IList<IWeaponProperty> Properties => throw new NotImplementedException();
    }
}
