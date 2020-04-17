using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWLongbow : AProfWeapon {
        public override string Name => "Longbow";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Longbow";

        public ProfMRWLongbow(string source) {
            Source = source;
        }
    }
}
