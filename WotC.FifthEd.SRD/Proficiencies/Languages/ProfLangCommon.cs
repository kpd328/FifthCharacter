using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangCommon : IProficiency {
        public string Name => "Common";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Common";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;
        
        internal ProfLangCommon() { }

        public ProfLangCommon(string source) {
            Source = source;
        }
    }
}
