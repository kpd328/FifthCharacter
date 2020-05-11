using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWNet : AProfWeapon {
        public override string Name => "Net";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialRanged.Net";

        internal ProfMRWNet() { }

        public ProfMRWNet(string source) {
            Source = source;
        }
    }
}
