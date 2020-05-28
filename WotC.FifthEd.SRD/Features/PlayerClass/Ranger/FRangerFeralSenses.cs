using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerFeralSenses : AFeatureRanger {
        public override string Name => "Feral Senses";
        public override string Text => FeatureRangerText.Feral_Senses;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerFeralSenses();
    }
}
