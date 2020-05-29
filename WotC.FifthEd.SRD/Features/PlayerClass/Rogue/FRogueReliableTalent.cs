using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueReliableTalent : AFeatureRogue {
        public override string Name => "Reliable Talent";
        public override string Text => FeatureRogueText.Reliable_Talent;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueReliableTalent();
    }
}
