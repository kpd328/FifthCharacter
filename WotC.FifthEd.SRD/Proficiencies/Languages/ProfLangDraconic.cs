using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangDraconic : IProficiency {
        public string Name => "Draconic";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Draconic";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangDraconic() { }

        public ProfLangDraconic(string source) {
            Source = source;
        }
    }
}
