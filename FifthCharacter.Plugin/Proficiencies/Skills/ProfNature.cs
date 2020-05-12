using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfNature : AProfSkill {
        public override string Name => "Nature";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Nature";

        internal ProfNature() { }

        public ProfNature(string source) {
            Source = source;
        }
    }
}
