using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public class FDruidBeastSpells : AFeatureDruid {
        public override string Name => "Beast Spells";
        public override string Text => FeatureDruidText.Beast_Spells;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FDruidBeastSpells();
    }
}
