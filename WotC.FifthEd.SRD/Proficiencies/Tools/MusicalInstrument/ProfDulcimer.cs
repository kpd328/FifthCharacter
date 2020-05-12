namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfDulcimer : AProfMusicalInstrument {
        public override string Name => "Dulcimer";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Dulcimer";

        internal ProfDulcimer() : base() { }

        public ProfDulcimer(string source) : base(source) { }
    }
}
