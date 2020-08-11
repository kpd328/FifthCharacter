using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Necromancy {
    public class AnimateDead : ASchoolNecromancy {
        public override SpellLevel SpellLevel => SpellLevel.THIRD_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 minute";
        public override string Range => "10 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S",
            "M (a drop of blood, a piece of flash, and a pinch of bone dust)"
        };
        public override string Duration => "Instantaneous";
        public override string Targets => "A pile of bones or a corpse of a Medium or Small humanoid within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Animate Dead";

        public override string Description => SpellDescriptions.AnimateDead;

        public override IMagic GetInstance() => new AnimateDead();
    }
}
