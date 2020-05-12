using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Proficiencies.Tools {
    public class ProfHerbalismKit : IProficiency {
        public string Name => "Herbalism Kit";
        public string Source { get; set; }
        public string ID => "SRD.Proficiency.Tool.HerbalismKit";
        public ProficiencyType ProficiencyType => ProficiencyType.TOOL;
    }
}
