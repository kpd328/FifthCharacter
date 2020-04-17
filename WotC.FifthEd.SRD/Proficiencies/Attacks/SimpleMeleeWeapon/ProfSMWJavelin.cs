using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWJavelin : AProfWeapon {
        public override string Name => "Javelin";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Javelin";
        
        public ProfSMWJavelin(string source) {
            Source = source;
        }
    }
}
