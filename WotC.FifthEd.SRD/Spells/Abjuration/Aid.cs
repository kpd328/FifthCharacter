﻿using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Abjuration {
    public class Aid : ASchoolAbjuration {
        public override SpellLevel SpellLevel => SpellLevel.SECOND_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "30 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S",
            "M (a tiny strip of white cloth)"
        };
        public override string Duration => "8 hours";
        public override string Targets => "Up to three creatures within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Aid";
        public override string Description => SpellDescriptions.Aid;
        public new string AtHigherLevels => AtHigherLevelsDescriptions.Aid;

        public override IMagic GetInstance() => new Aid();
    }
}
