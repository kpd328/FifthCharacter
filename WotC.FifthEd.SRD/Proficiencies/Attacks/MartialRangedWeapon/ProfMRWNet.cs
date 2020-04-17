using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWNet : AProfWeapon {
        public override string Name => "Net";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Net";

        public ProfMRWNet(string source) {
            Source = source;
        }
    }
}
