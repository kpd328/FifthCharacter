using FifthCharacter.Plugin.Proficiencies.Abstract;

namespace WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon {
    public class ProfMMWBattleaxe : AProfWeapon {
        public override string Name => "Battleaxe";
        public override string Source { get; set; }
        public override string ID => "Weapon.Proficiency.MartialMelee.Battleaxe";

        internal ProfMMWBattleaxe() { }

        public ProfMMWBattleaxe(string source) {
            Source = source;
        }
    }
}
