namespace WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools {
    public class ProfCooksUtensils : AProfArtisansTools {
        public override string Name => "Cook's Utensils";
        public override string ID => "SRD.Proficiency.Tool.ArtisansTools.CooksUtensils";

        internal ProfCooksUtensils() : base() { }

        public ProfCooksUtensils(string source) : base(source) { }
    }
}
