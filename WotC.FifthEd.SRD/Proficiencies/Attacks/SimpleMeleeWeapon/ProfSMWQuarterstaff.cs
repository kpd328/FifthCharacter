using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWQuarterstaff : AProfWeapon {
        public override string Name => "Quarterstaff";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Quarterstaff";

        internal ProfSMWQuarterstaff() { }
        
        public ProfSMWQuarterstaff(string source) {
            Source = source;
        }
    }
}
