using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon {
    public class ProfSRWLightCrossbow : AProfWeapon {
        public override string Name => "Light Crossbow";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.SimpleRanged.LightCrossbow";

        public ProfSRWLightCrossbow(string source) {
            Source = source;
        }
    }
}
