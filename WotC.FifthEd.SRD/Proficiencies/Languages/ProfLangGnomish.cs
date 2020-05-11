using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangGnomish : IProficiency {
        public string Name => "Gnomish";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Gnomish";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangGnomish() { }

        public ProfLangGnomish(string source) {
            Source = source;
        }
    }
}
