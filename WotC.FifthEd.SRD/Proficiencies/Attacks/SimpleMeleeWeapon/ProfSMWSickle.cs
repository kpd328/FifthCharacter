using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleMeleeWeapon {
    public class ProfSMWSickle : AProfWeapon {
        public override string Name => "Sickle";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleMelee.Sickle";
        
        public ProfSMWSickle(string source) {
            Source = source;
        }
    }
}
