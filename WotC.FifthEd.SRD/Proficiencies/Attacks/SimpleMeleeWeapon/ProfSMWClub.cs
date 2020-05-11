using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWClub : AProfWeapon {
        public override string Name => "Club";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Club";

        internal ProfSMWClub() { }
        
        public ProfSMWClub(string source) {
            Source = source;
        }
    }
}
