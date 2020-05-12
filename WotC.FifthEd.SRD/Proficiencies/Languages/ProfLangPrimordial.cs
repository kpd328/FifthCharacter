using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangPrimordial : IProficiency {
        public string Name => "Primordial";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Primordial";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangPrimordial() { }

        public ProfLangPrimordial(string source) {
            Source = source;
        }
    }
}
