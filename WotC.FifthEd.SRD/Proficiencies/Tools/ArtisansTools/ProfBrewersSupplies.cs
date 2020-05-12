namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfBrewersSupplies : AProfArtisansTools {
        public override string Name => "Brewer's Supplies";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.BrewersSupplies";

        internal ProfBrewersSupplies() : base() { }

        public ProfBrewersSupplies(string source) : base(source) { }
    }
}
