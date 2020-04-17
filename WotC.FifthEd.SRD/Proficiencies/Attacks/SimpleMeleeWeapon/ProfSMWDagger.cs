using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWDagger : AProfWeapon {
        public override string Name => "Dagger";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Dagger";
        
        public ProfSMWDagger(string source) {
            Source = source;
        }
    }
}
