using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWMace : AProfWeapon {
        public override string Name => "Mace";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Mace";

        internal ProfSMWMace() { }
        
        public ProfSMWMace(string source) {
            Source = source;
        }
    }
}
