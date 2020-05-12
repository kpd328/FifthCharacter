namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfLyre : AProfMusicalInstrument {
        public override string Name => "Lyre";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Lyre";

        internal ProfLyre() : base() { }

        public ProfLyre(string source) : base(source) { }
    }
}
