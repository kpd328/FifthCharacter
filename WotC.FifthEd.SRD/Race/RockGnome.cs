using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Gnome.Rock;
using WotC.FifthEd.SRD.Proficiencies.Tools.ArtisansTools;

namespace WotC.FifthEd.SRD.Race {
    public class RockGnome : AGnome {
        private const string SOURCE_TEXT = "Race Gnome (Rock)";
        public override string Name => "Rock Gnome";
        public override string ID => "SRD.Race.Gnome.Rock";

        public RockGnome() { }

        protected RockGnome(bool isRace) : base() {
            FeaturesManager.Features.Add(new FRockGnomeAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FRockGnomeArtificersLore());
            FeaturesManager.Features.Add(new FRockGnomeTinker());
            ProficiencyManager.Proficiencies.Add(new ProfTinkersTools(SOURCE_TEXT));
        }

        public override IRace GetInstance() => new RockGnome(true);
    }
}
