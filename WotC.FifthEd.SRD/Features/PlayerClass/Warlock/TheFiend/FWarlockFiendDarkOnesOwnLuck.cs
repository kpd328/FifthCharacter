using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockFiendDarkOnesOwnLuck : AFeatureWarlockFiend {
        public override string Name => "Dark One's Own Luck";
        public override string Text => FeatureWarlockFiendText.Dark_One_s_Own_Luck;
        public override bool IsActive => true;
        public override int ActiveUses => 1;

        public override IFeature GetInstance() => new FWarlockFiendDarkOnesOwnLuck();
    }
}
