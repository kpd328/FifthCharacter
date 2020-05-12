using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangGiant : IProficiency {
        public string Name => "Giant";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Giant";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangGiant() { }

        public ProfLangGiant(string source) {
            Source = source;
        }
    }
}
