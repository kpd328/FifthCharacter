using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public class FSorcererDraconicBloodlineElementalAffinity : AFeatureSorcerer {
        public override string Name => "Elemental Affinity";
        public override string Text => FeatureSorcererDraconicBloodline.Elemental_Affinity;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererDraconicBloodlineElementalAffinity();
    }
}
