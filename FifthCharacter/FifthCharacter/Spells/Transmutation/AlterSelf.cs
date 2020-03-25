﻿using FifthCharacter.Interface;
using FifthCharacter.Spells.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FifthCharacter.Spells.Transmutation {
    public class AlterSelf : ASchoolTransmutation {
        public override SpellLevel SpellLevel => SpellLevel.SECOND_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "Self";
        public override IList<string> Components => new List<string>() {
            "V",
            "S"
        };
        public override string Duration => "Concentration, up to 1 hour";
        public override string Targets => "Self";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Alter Self";
    }
}
