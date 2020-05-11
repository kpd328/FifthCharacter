using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWWarPick : AProfWeapon {
        public override string Name => "War Pick";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.WarPick";

        internal ProfMMWWarPick() { }

        public ProfMMWWarPick(string source) {
            Source = source;
        }
    }
}
