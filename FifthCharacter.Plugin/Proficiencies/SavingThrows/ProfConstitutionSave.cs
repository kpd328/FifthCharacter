﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfConstitutionSave : AProfSave {
        public override string Name => "Constitution Saving Throws";
        public override string Source { get; }
        public override string ID => "SavingThrow.Proficiency.Constitution";
        public ProfConstitutionSave(string source) {
            Source = source;
        }
    }
}
