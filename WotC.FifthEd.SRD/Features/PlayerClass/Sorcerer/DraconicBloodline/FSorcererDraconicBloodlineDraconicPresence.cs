using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererDraconicBloodlineDraconicPresence : AFeatureSorcererDraconicBloodline {
        public override string Name => "Draconic Presence";
        public override string Text => FeatureSorcererDraconicBloodline.Draconic_Presence;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererDraconicBloodlineDraconicPresence();
    }
}
