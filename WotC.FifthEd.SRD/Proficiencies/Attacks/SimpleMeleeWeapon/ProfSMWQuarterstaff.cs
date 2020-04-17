using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWQuarterstaff : AProfWeapon {
        public override string Name => "Quarterstaff";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Quarterstaff";
        
        public ProfSMWQuarterstaff(string source) {
            Source = source;
        }
    }
}
