using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public class FWarlockEldritchMaster : AFeatureWarlock {
        public override string Name => "Eldritch Master";
        public override string Text => FeatureWarlockText.Eldritch_Master;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FWarlockEldritchMaster();
    }
}
