using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public abstract class AProfGamingSet : IProficiency {
        public virtual string Name => "Gaming Set";
        public string Source { get; set; }
        public abstract string ID { get; }
        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;

        internal AProfGamingSet() { }

        public AProfGamingSet(string source) {
            Source = source;
        }
    }
}
