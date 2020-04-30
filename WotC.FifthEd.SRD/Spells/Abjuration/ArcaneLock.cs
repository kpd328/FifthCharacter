using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace WotC.FifthEd.SRD.Spells.Abjuration {
    public class ArcaneLock : ASchoolAbjuration {
        public override SpellLevel SpellLevel => SpellLevel.SECOND_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "Touch";
        public override IList<string> Components => new List<string>() {
            "V",
            "S",
            "M (gold dust worth at least 25 gp, which the spell consumes)"
        };
        public override string Duration => "Until dispelled";
        public override string Targets => "A closed door, window, gate, chest, or other entryway";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Arcane Lock";
        public override string Description => throw new NotImplementedException();

        public override IMagic GetInstance() => new ArcaneLock();
    }
}
