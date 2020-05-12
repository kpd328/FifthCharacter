namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfDrum : AProfMusicalInstrument {
        public override string Name => "Drum";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Drum";

        internal ProfDrum() : base() { }

        public ProfDrum(string source) : base(source) { }
    }
}
