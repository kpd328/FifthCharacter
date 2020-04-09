using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Evocation {
    public class AcidArrow : ASchoolEvocation, IRangedSpellAttack {
        public override SpellLevel SpellLevel => throw new System.NotImplementedException();
        public override bool Ritual => throw new System.NotImplementedException();
        public override string CastingTime => throw new System.NotImplementedException();
        public override string Range => throw new System.NotImplementedException();
        public override IList<string> Components => throw new System.NotImplementedException();
        public override string Duration => throw new System.NotImplementedException();
        public override string Targets => throw new System.NotImplementedException();
        public override string AreaOfEffect => throw new System.NotImplementedException();
        public override string Name => throw new System.NotImplementedException();

        public string AttackBonus => throw new System.NotImplementedException();
        public string DamageDice => throw new System.NotImplementedException();
        public string DamageType => throw new System.NotImplementedException();

        public override IMagic GetInstance() {
            throw new System.NotImplementedException();
        }

        IAttack IAttack.GetInstance() {
            throw new System.NotImplementedException();
        }
    }
}
