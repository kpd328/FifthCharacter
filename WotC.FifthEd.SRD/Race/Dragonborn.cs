using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Dragonborn;

namespace WotC.FifthEd.SRD.Race {
    public class Dragonborn : IRace {
        public string Name => "Dragonborn";
        public string ID => "SRD.Race.Dragonborn";
        public DraconicAncestry Ancestry { get; private set; }

        public Dragonborn() { }

        protected Dragonborn(bool isRace) {
            CharacterManager.Speed = 30;

            //TODO: Prompt to pick ancestry
            FeaturesManager.Features.Add(new FDragonbornAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FDragonbornBreathWeapon(Ancestry));
            FeaturesManager.Features.Add(new FDragonbornDamageResistance(Ancestry));
        }

        public IRace GetInstance() => new Dragonborn(true);
    }

    public enum DraconicAncestry {
        BLACK,
        BLUE,
        BRASS,
        BRONZE,
        COPPER,
        GOLD,
        GREEN,
        RED,
        SILVER,
        WHITE
    }
}
