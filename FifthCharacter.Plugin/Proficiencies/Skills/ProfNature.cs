﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfNature : AProfSkill {
        public override string Name => "Nature";
        public override string Source { get; }
        public override string ID => "Skill.Proficiency.Nature";
        public ProfNature(string source) {
            Source = source;
        }
    }
}
