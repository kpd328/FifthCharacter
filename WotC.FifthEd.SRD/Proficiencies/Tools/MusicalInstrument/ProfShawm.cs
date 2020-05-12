namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfShawm : AProfMusicalInstrument {
        public override string Name => "Shawm";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Shawm";

        internal ProfShawm() : base() { }

        public ProfShawm(string source) : base(source) { }
    }
}
