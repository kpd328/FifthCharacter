using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfArcana : AProfSkill {
        public override string Name => "Arcana";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Arcana";

        internal ProfArcana() { }

        public ProfArcana(string source) {
            Source = source;
        }
    }
}
