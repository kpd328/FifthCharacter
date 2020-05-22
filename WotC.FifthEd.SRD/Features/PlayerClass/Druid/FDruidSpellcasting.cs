using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidSpellcasting : AFeatureDruid {
        public override string Name => "Spellcasting";
        public override string Text => FeatureDruidText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidSpellcasting();
    }
}
