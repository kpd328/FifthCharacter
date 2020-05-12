using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangUndercommon : IProficiency {
        public string Name => "Undercommon";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Undercommon";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangUndercommon() { }

        public ProfLangUndercommon(string source) {
            Source = source;
        }
    }
}
