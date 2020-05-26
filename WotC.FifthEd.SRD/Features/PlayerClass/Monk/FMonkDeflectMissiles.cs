using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk {
    public class FMonkDeflectMissiles : AFeatureMonk {
        public override string Name => "Deflect Missiles";
        public override string Text => FeatureMonkText.Deflect_Missiles;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FMonkDeflectMissiles();
    }
}
