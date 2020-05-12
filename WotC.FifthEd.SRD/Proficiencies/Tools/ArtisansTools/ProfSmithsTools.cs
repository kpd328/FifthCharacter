namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfSmithsTools : AProfArtisansTools {
        public override string Name => "Smith's Tools";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.SmithsTools";

        internal ProfSmithsTools() : base() { }

        public ProfSmithsTools(string source) : base(source) { }
    }
}
