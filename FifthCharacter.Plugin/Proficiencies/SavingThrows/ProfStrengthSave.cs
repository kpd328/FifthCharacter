﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfStrengthSave : AProfSave {
        public override string Name => "Strength Saving Throws";
        public override string Source { get; set; }
        public override string ID => "SavingThrow.Proficiency.Strength";

        internal ProfStrengthSave() { }

        public ProfStrengthSave(string source) {
            Source = source;
        }
    }
}
