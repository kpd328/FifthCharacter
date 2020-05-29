using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.Proficiencies.SavingThrows;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueSlipperyMind : AFeatureRogue {
        public override string Name => "Slippery Mind";
        public override string Text => FeatureRogueText.Slippery_Mind;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public override bool IsAbilityMod => true;

        public override IFeature GetInstance() => new FRogueSlipperyMind();

        public override void ModAbility() {
            ProficiencyManager.Proficiencies.Add(new ProfWisdomSave("Class Rogue"));
        }
    }
}
