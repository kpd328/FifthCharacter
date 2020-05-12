using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public class ProfNavigatorsTools : IProficiency {
        public string Name => "Navigator's Tools";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Tool.NavigatorsTools";

        internal ProfNavigatorsTools() { }

        public ProfNavigatorsTools(string source) {
            Source = source;
        }

        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;
    }
}
