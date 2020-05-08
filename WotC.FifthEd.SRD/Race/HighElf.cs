using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Features.Race.Elf.High;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialMeleeWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.MartialRangedWeapon;
using WotC.FifthEd.SRD.Proficiencies.Attacks.SimpleRangedWeapon;

namespace WotC.FifthEd.SRD.Race {
    public class HighElf : AElf {
        private const string SOURCE_TEXT = "Race Elf (High)";
        public new string Name => "High Elf";
        public override string ID => "SRD.Race.Elf.High";

        public HighElf() { }

        protected HighElf(bool isRace) : base() {
            FeaturesManager.Features.Add(new FHighElfAbilityScoreIncrease());
            FeaturesManager.Features.Add(new FHighElfCantrip());

            ProficiencyManager.Proficiencies.Add(new ProfMMWLongsword(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMMWShortsword(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfSRWShortbow(SOURCE_TEXT));
            ProficiencyManager.Proficiencies.Add(new ProfMRWLongbow(SOURCE_TEXT));

            //TODO: Prompt for extra language
        }

        public override IRace GetInstance() => new HighElf();
    }
}
