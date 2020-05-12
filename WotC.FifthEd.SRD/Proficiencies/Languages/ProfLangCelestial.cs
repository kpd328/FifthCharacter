using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangCelestial : IProficiency {
        public string Name => "Celestial";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Celestial";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangCelestial() { }

        public ProfLangCelestial(string source) {
            Source = source;
        }
    }
}
