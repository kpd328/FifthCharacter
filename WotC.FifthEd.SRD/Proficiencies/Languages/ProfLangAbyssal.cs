using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangAbyssal : IProficiency {
        public string Name => "Abyssal";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Abyssal";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangAbyssal() { }

        public ProfLangAbyssal(string source) {
            Source = source;
        }
    }
}
