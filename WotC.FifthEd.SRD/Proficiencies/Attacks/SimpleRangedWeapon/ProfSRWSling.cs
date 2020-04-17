using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon {
    public class ProfSRWSling : AProfWeapon {
        public override string Name => "Sling";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleRanged.Sling";
        
        public ProfSRWSling(string source) {
            Source = source;
        }
    }
}
