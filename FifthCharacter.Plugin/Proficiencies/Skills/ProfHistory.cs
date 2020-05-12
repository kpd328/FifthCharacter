using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfHistory : AProfSkill {
        public override string Name => "History";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.History";

        internal ProfHistory() { }

        public ProfHistory(string source) {
            Source = source;
        }
    }
}
