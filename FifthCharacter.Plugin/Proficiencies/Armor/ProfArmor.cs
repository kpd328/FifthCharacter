﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace FifthCharacter.Plugin.Proficiencies.Armor {
    public class ProfArmor : AProfArmor {
        public override string Name => "All Armor";
        public override string Source { get; set; }
        public override string ID => "Armor.Proficiency.All";

        internal ProfArmor() { }
        
        public ProfArmor(string source) {
            Source = source;
        }
    }
}
