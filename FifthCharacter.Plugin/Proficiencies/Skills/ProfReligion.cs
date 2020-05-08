using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfReligion : AProfSkill {
        public override string Name => "Religion";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Religion";
        public ProfReligion(string source) {
            Source = source;
        }
    }
}
