using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWBlowgun : AProfWeapon {
        public override string Name => "Blowgun";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Blowgun";

        public ProfMRWBlowgun(string source) {
            Source = source;
        }
    }
}
