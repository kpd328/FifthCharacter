using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public class FWarlockFiendFiendishResilience : AFeatureWarlockFiend {
        public override string Name => "Fiendish Resilience";
        public override string Text => FeatureWarlockFiendText.Fiendish_Resilience;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWarlockFiendFiendishResilience();
    }
}
