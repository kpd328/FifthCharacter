using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangThievesCant : IProficiency {
        public string Name => "Thieves' Cant";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.ThievesCant";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangThievesCant() { }

        public ProfLangThievesCant(string source) {
            Source = source;
        }
    }
}
