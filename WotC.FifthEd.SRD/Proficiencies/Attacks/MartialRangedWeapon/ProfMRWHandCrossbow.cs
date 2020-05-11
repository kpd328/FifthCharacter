using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWHandCrossbow : AProfWeapon {
        public override string Name => "Hand Crossbow";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialRanged.HandCrossbow";

        internal ProfMRWHandCrossbow() { }

        public ProfMRWHandCrossbow(string source) {
            Source = source;
        }
    }
}
