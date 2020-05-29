using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueCunningAction : AFeatureRogue {
        public override string Name => "Cunning Action";
        public override string Text => FeatureRogueText.Cunning_Action;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueCunningAction();
    }
}
