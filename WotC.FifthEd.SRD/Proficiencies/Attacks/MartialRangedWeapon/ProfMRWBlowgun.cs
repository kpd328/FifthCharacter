using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWBlowgun : AProfWeapon {
        public override string Name => "Blowgun";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Blowgun";

        internal ProfMRWBlowgun() { }

        public ProfMRWBlowgun(string source) {
            Source = source;
        }
    }
}
