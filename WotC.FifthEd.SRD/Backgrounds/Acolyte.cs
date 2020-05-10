using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.Skills;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Background;

namespace WotC.FifthEd.SRD.Backgrounds {
    public class Acolyte : IBackground {
        private const string SOURCE_TEXT = "Background Acolyte";
        public string Name => "Acolyte";
        public string ID => "SRD.Background.Acolyte";

        public Acolyte() { }

        protected Acolyte(bool isBackground) {
            ProficiencyManager.Proficiencies.Add(new ProfInsight(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfReligion(SOURCE_TEXT));
            //TODO: prompt for 2 Languages
            //TODO: equipment (plus prompt for options
            FeaturesManager.Features.Add(new FAcolyteShelterOfTheFaithful());
        }

        public IBackground GetInstance() => new Acolyte(true);
    }
}
