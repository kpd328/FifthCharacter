using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangOrc : IProficiency {
        public string Name => "Orc";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Orc";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangOrc() { }

        public ProfLangOrc(string source) {
            Source = source;
        }
    }
}
