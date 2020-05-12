namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfHorn : AProfMusicalInstrument {
        public override string Name => "Horn";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Horn";

        internal ProfHorn() : base() { }

        public ProfHorn(string source) : base(source) { }
    }
}
