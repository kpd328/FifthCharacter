using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererDraconicBloodlineDragonWings : AFeatureSorcererDraconicBloodline {
        public override string Name => "Dragon Wings";
        public override string Text => FeatureSorcererDraconicBloodline.Dragon_Wings;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererDraconicBloodlineDragonWings();
    }
}
