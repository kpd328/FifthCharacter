﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Skills {
    public class ProfPersuasion : AProfSkill {
        public override string Name => "Persuasion";
        public override string Source { get; set; }
        public override string ID => "Skill.Proficiency.Persuasion";

        internal ProfPersuasion() { }

        public ProfPersuasion(string source) {
            Source = source;
        }
    }
}
