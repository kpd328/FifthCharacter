using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfIntimidation : AProfSkill {
        public override string Name => "Intimidation";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Intimidation";

        internal ProfIntimidation() { }

        public ProfIntimidation(string source) {
            Source = source;
        }
    }
}
