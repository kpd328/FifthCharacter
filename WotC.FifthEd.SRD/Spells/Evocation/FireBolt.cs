using FifthCharacter.Plugin.Attacks.Abstract;
using FifthCharacter.Plugin.Interface;
using System.Collections.Generic;
using WotC.FifthEd.SRD.Spells.Abstract;

namespace WotC.FifthEd.SRD.Spells.Evocation {
    public class FireBolt : ASchoolEvocation, IRangedSpellAttack {
        public override SpellLevel SpellLevel => SpellLevel.CANTRIP;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "120 Feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S"
        };
        public override string Duration => "Instantanious";
        public override string Targets => "A crature or object within range";
        public override string AreaOfEffect => "N/A";

        public override string Name => "Fire Bolt";
        public string AttackBonus { get; }
        public string DamageDice => "1d10";
        public string DamageType => "Fire";

        public override IMagic GetInstance() => new FireBolt();
        IAttack IAttack.GetInstance() => new FireBolt();
    }
}
