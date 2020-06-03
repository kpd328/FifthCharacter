using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockFiendDarkOnesBlessing : AFeatureWarlockFiend {
        public override string Name => "Dark One's Blessing";
        public override string Text => FeatureWarlockFiendText.Dark_One_s_Blessing;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWarlockFiendDarkOnesBlessing();
    }
}
