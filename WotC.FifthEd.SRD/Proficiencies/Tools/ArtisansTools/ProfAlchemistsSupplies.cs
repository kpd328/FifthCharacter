namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfAlchemistsSupplies : AProfArtisansTools {
        public override string Name => "Alchemist's Supplies";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.AlchemistsSupplies";

        internal ProfAlchemistsSupplies() : base() { }

        public ProfAlchemistsSupplies(string source) : base(source) { }
    }
}
