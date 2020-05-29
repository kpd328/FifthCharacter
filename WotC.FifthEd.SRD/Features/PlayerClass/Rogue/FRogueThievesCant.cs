using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;
using WotC.FifthEd.SRD.Proficiencies.Languages;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueThievesCant : AFeatureRogue {
        public override string Name => "Thieves' Cant";
        public override string Text => FeatureRogueText.Thieves__Cant;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        internal FRogueThievesCant() { }

        public FRogueThievesCant(bool isTaken) {
            ProficiencyManager.Proficiencies.Add(new ProfLangThievesCant("Class Rogue"));
        }

        public override IFeature GetInstance() => new FRogueThievesCant(true);
    }
}
