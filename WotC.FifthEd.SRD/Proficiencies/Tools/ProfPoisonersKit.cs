using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public class ProfPoisonersKit : IProficiency {
        public string Name => "Poisoner's Kit";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Tool.PoisonersKit";

        internal ProfPoisonersKit() { }

        public ProfPoisonersKit(string source) {
            Source = source;
        }

        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;
    }
}
