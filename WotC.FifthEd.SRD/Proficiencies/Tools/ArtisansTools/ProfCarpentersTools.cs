namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfCarpentersTools : AProfArtisansTools {
        public override string Name => "Carpenter's Tools";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.CarpentersTools";

        internal ProfCarpentersTools() : base() { }

        public ProfCarpentersTools(string source) : base(source) { }
    }
}
