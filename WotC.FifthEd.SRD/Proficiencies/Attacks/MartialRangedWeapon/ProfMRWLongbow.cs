using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWLongbow : AProfWeapon {
        public override string Name => "Longbow";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Longbow";

        internal ProfMRWLongbow() { }

        public ProfMRWLongbow(string source) {
            Source = source;
        }
    }
}
