namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfFlute : AProfMusicalInstrument {
        public override string Name => "Flute";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Flute";

        internal ProfFlute() : base() { }

        public ProfFlute(string source) : base(source) { }
    }
}
