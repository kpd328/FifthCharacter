using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWJavelin : AProfWeapon {
        public override string Name => "Javelin";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Javelin";

        internal ProfSMWJavelin() { }
        
        public ProfSMWJavelin(string source) {
            Source = source;
        }
    }
}
