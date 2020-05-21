using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public class FClericDestroyUndead : AFeatureCleric {
        public override string Name => "Destroy Undead";
        public override string Text => FeatureClericText.Destroy_Undead;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericDestroyUndead();
    }
}
