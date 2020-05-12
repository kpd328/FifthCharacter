namespace WotC.FifthEd.SRD.Proficiencies.Tools.GamingSet {
    public class ProfDiceSet : AProfGamingSet {
        public override string Name => "Dice Set";
        public override string ID => "SRD.Proficiency.Tool.GamingSet.DiceSet";

        internal ProfDiceSet() : base() { }

        public ProfDiceSet(string source) : base(source) { }
    }
}
