namespace WotC.FifthEd.SRD.Proficiencies.Tools.GamingSet {
    public class ProfPlayingCardSet : AProfGamingSet {
        public override string Name => "Playing Card Set";
        public override string ID => "SRD.Proficiency.Tool.GamingSet.PlayingCardSet";

        internal ProfPlayingCardSet() : base() { }

        public ProfPlayingCardSet(string source) : base(source) { }
    }
}
