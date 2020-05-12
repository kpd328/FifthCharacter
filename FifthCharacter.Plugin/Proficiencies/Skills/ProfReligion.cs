using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfReligion : AProfSkill {
        public override string Name => "Religion";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Religion";

        internal ProfReligion() { }

        public ProfReligion(string source) {
            Source = source;
        }
    }
}
