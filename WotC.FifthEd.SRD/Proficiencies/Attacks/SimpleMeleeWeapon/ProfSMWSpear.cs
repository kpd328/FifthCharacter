﻿using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWSpear : AProfWeapon {
        public override string Name => "Spear";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Spear";
        
        public ProfSMWSpear(string source) {
            Source = source;
        }
    }
}
