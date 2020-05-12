using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public class ProfThievesTools : IProficiency {
        public string Name => "Thieves' Tools";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Tool.ThievesTools";

        internal ProfThievesTools() { }

        public ProfThievesTools(string source) {
            Source = source;
        }

        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;
    }
}
