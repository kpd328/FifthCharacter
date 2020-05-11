using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfStealth : AProfSkill {
        public override string Name => "Stealth";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Stealth";
        public ProfStealth(string source) {
            Source = source;
        }
    }
}
