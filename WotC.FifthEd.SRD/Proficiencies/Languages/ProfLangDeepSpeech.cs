using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Languages {
    public class ProfLangDeepSpeech : IProficiency {
        public string Name => "Deep Speech";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Language.DeepSpeech";
        public ProficiencyType ProficiencyType => ProficiencyType.LANGUAGE;

        internal ProfLangDeepSpeech() { }

        public ProfLangDeepSpeech(string source) {
            Source = source;
        }
    }
}
