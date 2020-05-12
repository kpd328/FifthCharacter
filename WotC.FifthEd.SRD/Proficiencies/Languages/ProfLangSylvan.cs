using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangSylvan : IProficiency {
        public string Name => "Sylvan";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Sylvan";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;
        
        internal ProfLangSylvan() { }

        public ProfLangSylvan(string source) {
            Source = source;
        }
    }
}
