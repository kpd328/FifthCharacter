using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon {
    public class ProfMRWHeavyCrossbow : AProfWeapon {
        public override string Name => "Heavy Crossbow";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialRanged.HeavyCrossbow";

        public ProfMRWHeavyCrossbow(string source) {
            Source = source;
        }
    }
}
