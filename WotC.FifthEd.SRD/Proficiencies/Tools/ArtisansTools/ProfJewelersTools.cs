namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfJewelersTools : AProfArtisansTools {
        public override string Name => "Jeweler's Tools";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.JewelersTools";

        internal ProfJewelersTools() : base() { }

        public ProfJewelersTools(string source) : base(source) { }
    }
}
