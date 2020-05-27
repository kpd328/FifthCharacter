using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public class FPaladinSpellcasting : AFeaturePaladin {
        public override string Name => "Spellcasting";
        public override string Text => FeaturePaladinText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FPaladinSpellcasting();
    }
}
