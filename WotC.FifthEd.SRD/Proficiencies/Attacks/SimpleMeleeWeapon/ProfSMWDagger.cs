using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWDagger : AProfWeapon {
        public override string Name => "Dagger";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Dagger";

        internal ProfSMWDagger() { }
        
        public ProfSMWDagger(string source) {
            Source = source;
        }
    }
}
