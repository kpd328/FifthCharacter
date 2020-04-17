using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWWarPick : AProfWeapon {
        public override string Name => "War Pick";
        public override string Source { get; }
        public override string ID => "Weapon.Proficiency.MartialMelee.WarPick";

        public ProfMMWWarPick(string source) {
            Source = source;
        }
    }
}
