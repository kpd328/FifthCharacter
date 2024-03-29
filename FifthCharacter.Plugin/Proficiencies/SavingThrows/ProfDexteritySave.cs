﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.SavingThrows {
    public class ProfDexteritySave : AProfSave {
        public override string Name => "Dexterity Saving Throws";
        public override string Source { get; set; }
        public override string ID => "SavingThrow.Proficiency.Dexterity";

        internal ProfDexteritySave() { }

        public ProfDexteritySave(string source) {
            Source = source;
        }
    }
}
