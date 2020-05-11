using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangElvish : IProficiency {
        public string Name => "Elvish";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Elvish";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangElvish() { }

        public ProfLangElvish(string source) {
            Source = source;
        }
    }
}
