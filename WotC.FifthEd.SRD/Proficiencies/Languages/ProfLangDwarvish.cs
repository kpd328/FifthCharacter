using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangDwarvish : IProficiency {
        public string Name => "Dwarvish";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Dwarvish";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangDwarvish() { }

        public ProfLangDwarvish(string source) {
            Source = source;
        }
    }
}
