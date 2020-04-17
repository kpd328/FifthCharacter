using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWHandaxe : AProfWeapon {
        public override string Name => "Handaxe";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Handaxe";
        
        public ProfSMWHandaxe(string source) {
            Source = source;
        }
    }
}
