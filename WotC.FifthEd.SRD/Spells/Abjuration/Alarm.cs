using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Abjuration {
    public class Alarm : ASchoolAbjuration {
        public override SpellLevel SpellLevel => SpellLevel.FIRST_LEVEL;
        public override bool Ritual => true;
        public override string CastingTime => "1 minute";
        public override string Range => "30 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S",
            "M (a tiny bell and a piece of fine silver wire)"
        };
        public override string Duration => "8 hours";
        public override string Targets => "A door, a window, or an area within range that is no larger than a 20-foot cube";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Alarm";
        public override string Description => SpellDescriptions.Alarm;

        public override IMagic GetInstance() => new Alarm();
    }
}
