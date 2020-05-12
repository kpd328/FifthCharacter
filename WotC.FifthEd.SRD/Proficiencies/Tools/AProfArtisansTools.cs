using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public abstract class AProfArtisansTools : IProficiency {
        public virtual string Name => "Artisan's Tools";
        public string Source { get; set; }
        public abstract string ID { get; }
        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;

        internal AProfArtisansTools() { }

        public AProfArtisansTools(string source) {
            Source = source;
        }
    }
}
