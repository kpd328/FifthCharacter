namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfCustomInstrument : AProfMusicalInstrument {
        public override string Name { get; }
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Custom";

        internal ProfCustomInstrument() : base() { }

        public ProfCustomInstrument(string source) : base(source) { }

        public ProfCustomInstrument(string name, string source) : base(source) {
            Name = name;
        }
    }
}
