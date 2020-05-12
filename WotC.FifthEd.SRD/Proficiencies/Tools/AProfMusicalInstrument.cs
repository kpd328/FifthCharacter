using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public abstract class AProfMusicalInstrument : IProficiency {
        public virtual string Name => "Musical Instrument";
        public string Source { get; set; }
        public abstract string ID { get; }
        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;

        internal AProfMusicalInstrument() { }

        public AProfMusicalInstrument(string source) {
            Source = source;
        }
    }
}
