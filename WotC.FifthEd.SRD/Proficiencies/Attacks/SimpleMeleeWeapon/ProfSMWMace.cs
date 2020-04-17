using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWMace : AProfWeapon {
        public override string Name => "Mace";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Mace";
        
        public ProfSMWMace(string source) {
            Source = source;
        }
    }
}
