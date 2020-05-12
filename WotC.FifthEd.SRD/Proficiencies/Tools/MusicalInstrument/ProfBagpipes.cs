namespace WotC.FifthEd.SRD.Proficiencies.Tools.MusicalInstrument {
    public class ProfBagpipes : AProfMusicalInstrument {
        public override string Name => "Bagpipes";
        public override string ID => "SRD.Proficiency.Tool.MusicalInstrument.Bagpipes";

        internal ProfBagpipes() : base() { }

        public ProfBagpipes(string source) : base(source) { }
    }
}
