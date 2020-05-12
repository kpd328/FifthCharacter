namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfPanFlute : AProfMusicalInstrument {
        public override string Name => "Pan Flute";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.PanFlute";

        internal ProfPanFlute() : base() { }

        public ProfPanFlute(string source) : base(source) { }
    }
}
