using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangHalfling : IProficiency {
        public string Name => "Halfling";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Halfling";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangHalfling() { }

        public ProfLangHalfling(string source) {
            Source = source;
        }
    }
}
