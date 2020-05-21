using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public class FClericSpellcasting : AFeatureCleric {
        public override string Name => "Spellcasting";
        public override string Text => FeatureClericText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericSpellcasting();
    }
}
