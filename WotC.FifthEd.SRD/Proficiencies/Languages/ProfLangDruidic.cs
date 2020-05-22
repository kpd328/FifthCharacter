using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangDruidic : IProficiency {
        public string Name => "Druidic";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.Druidic";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangDruidic() { }

        public ProfLangDruidic(string source) {
            Source = source;
        }
    }
}
