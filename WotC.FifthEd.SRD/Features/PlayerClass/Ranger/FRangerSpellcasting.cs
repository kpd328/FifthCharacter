using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public class FRangerSpellcasting : AFeatureRanger {
        public override string Name => "Spellcasting";
        public override string Text => FeatureRangerText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRangerSpellcasting();
    }
}
