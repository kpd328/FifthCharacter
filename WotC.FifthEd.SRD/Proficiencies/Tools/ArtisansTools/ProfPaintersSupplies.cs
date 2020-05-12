namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfPaintersSupplies : AProfArtisansTools {
        public override string Name => "Painter's Supplies";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.PaintersSupplies";

        internal ProfPaintersSupplies() : base() { }

        public ProfPaintersSupplies(string source) : base(source) { }
    }
}
