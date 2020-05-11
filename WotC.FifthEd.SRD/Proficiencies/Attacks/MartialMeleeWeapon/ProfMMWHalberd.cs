using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWHalberd : AProfWeapon {
        public override string Name => "Halberd";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Halberd";

        internal ProfMMWHalberd() { }

        public ProfMMWHalberd(string source) {
            Source = source;
        }
    }
}
