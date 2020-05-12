namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfViol : AProfMusicalInstrument {
        public override string Name => "Viol";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Viol";

        internal ProfViol() : base() { }

        public ProfViol(string source) : base(source) { }
    }
}
