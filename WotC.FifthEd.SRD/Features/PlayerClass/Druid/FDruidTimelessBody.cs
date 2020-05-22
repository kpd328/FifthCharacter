using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidTimelessBody : AFeatureDruid {
        public override string Name => "Timeless Body";
        public override string Text => FeatureDruidText.Timeless_Body;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidTimelessBody();
    }
}
