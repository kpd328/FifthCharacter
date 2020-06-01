using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererDraconicBloodlineDraconicResilience : AFeatureSorcererDraconicBloodline {
        public override string Name => "Draconic Resilience";
        public override string Text => FeatureSorcererDraconicBloodline.Draconic_Resilience;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererDraconicBloodlineDraconicResilience();
    }
}
