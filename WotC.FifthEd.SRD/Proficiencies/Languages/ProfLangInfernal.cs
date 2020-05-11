using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangInfernal : IProficiency {
        public string Name => "Infernal";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Infernal";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangInfernal() { }

        public ProfLangInfernal(string source) {
            Source = source;
        }
    }
}
