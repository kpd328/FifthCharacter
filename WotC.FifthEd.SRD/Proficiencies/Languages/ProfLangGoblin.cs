using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangGoblin : IProficiency {
        public string Name => "Goblin";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Goblin";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangGoblin() { }

        public ProfLangGoblin(string source) {
            Source = source;
        }
    }
}
