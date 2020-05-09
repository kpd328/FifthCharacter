using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Gnome.Rock;

namespace WotC.FifthEd.SRD.Race {
    public class RockGnome : AGnome {
        public new string Name => "Rock Gnome";
        public override string ID => "SRD.Race.Gnome.Rock";

        public RockGnome() { }

        protected RockGnome(bool isRace) : base() {
            FeaturesManager.Features.Add(new FRockGnomeAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FRockGnomeArtificersLore());
            FeaturesManager.Features.Add(new FRockGnomeTinker());
            //TODO: add tinker's tools proficiency
        }

        public override IRace GetInstance() => new RockGnome(true);
    }
}
