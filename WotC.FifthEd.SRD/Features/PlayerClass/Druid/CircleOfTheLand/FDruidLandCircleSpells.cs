using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public class FDruidLandCircleSpells : AFeatureDruidCircleOfTheLand {
        //TODO: Prompt to select the Land type and get level spells
        public override string Name => "Circle Spells";
        public override string Text => FeatureDruidCircleOfTheLandText.Circle_Spells;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidLandCircleSpells();
    }
}
