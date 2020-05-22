using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidArchdruid : AFeatureDruid {
        public override string Name => "Archdruid";
        public override string Text => FeatureDruidText.Archdruid;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidArchdruid();
    }
}
