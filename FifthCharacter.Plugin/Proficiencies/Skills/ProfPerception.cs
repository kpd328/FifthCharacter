using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfPerception : AProfSkill {
        public override string Name => "Perception";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Perception";

        internal ProfPerception() { }

        public ProfPerception(string source) {
            Source = source;
        }
    }
}
