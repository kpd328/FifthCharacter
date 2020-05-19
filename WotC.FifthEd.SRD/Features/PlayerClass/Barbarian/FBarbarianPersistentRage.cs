using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianPersistentRage : AFeatureBarbarian {
        public override string Name => "Persistent Rage";
        public override string Text => FeatureBarbarianText.Persistent_Rage;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianPersistentRage();
    }
}
