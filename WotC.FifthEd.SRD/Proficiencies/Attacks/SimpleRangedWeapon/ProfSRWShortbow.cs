using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon {
    public class ProfSRWShortbow : AProfWeapon {
        public override string Name => "Shortbow";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleRanged.Shortbow";
        
        public ProfSRWShortbow(string source) {
            Source = source;
        }
    }
}
