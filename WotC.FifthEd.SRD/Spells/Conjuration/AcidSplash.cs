using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Spells.Abstract;
using System.Collections.Generic;

namespace WotC.FifthEd.SRD.Spells.Conjuration {
    public class AcidSplash : ASchoolConjuration {
        public override SpellLevel SpellLevel => SpellLevel.CANTRIP;
        public override bool Ritual => false;
        public override string CastingTime => "1 Action";
        public override string Range => "60 feet";
        public override IList<string> Components => new List<string>() {
            "V",
            "S"
        };
        public override string Duration => "Instantaneous";
        public override string Targets => "One creature within range, or choose two creatures within range that are within 5 feet of each other.";
        public override string AreaOfEffect => "N/A";
        public override string Name => "Acid Splash";

        public override string Description => SpellDescriptions.AcidSplash;

        public override IMagic GetInstance() => new AcidSplash();
    }
}
