using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerFoeSlayer : AFeatureRanger {
        public override string Name => "Foe Slayer";
        public override string Text => FeatureRangerText.Foe_Slayer;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerFoeSlayer();
    }
}
