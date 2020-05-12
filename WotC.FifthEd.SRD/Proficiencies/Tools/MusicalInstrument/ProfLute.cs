namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfLute : AProfMusicalInstrument {
        public override string Name => "Lute";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Lute";

        internal ProfLute() : base() { }

        public ProfLute(string source) : base(source) { }
    }
}
