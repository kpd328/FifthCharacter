using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Dwarf.Hill;

namespace WotC.FifthEd.SRD.Race {
    public class HillDwarf : ADwarf {
        public new string Name => "Hill Dwarf";
        public override string ID => "SRD.Race.Dwarf.Hill";

        public HillDwarf() { }

        protected HillDwarf(bool isRace) : base() {
            FeaturesManager.Features.Add(new FHillDwarfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHillDwarfDwarvenToughness());
        }

        public override IRace GetInstance() => new HillDwarf(true);
    }
}
