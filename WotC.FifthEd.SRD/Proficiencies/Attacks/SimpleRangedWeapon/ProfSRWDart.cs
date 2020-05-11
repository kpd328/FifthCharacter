using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon {
    public class ProfSRWDart : AProfWeapon {
        public override string Name => "Dart";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.SimpleRanged.Dart";

        internal ProfSRWDart() { }
        
        public ProfSRWDart(string source) {
            Source = source;
        }
    }
}
