using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Transmutation {
    public class AnimalShapes : ASchoolTransmutation {
        public override SpellLevel SpellLevel => SpellLevel.EIGHTH_LEVEL;
        public override bool Ritual => false;
        public override string CastingTime => "1 action";
        public override string Range => "30 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S"
        };
        public override string Duration => "Concentration, up to 24 hours";
        public override string Targets => "Any number of willing creatures that you can see within range";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Animal Shapes";

        public override string Description => SpellDescriptions.AnimalShapes;

        public override IMagic GetInstance() => new AnimalShapes();
    }
}
