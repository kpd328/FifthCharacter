using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWSickle : AProfWeapon {
        public override string Name => "Sickle";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Sickle";

        internal ProfSMWSickle() { }
        
        public ProfSMWSickle(string source) {
            Source = source;
        }
    }
}
