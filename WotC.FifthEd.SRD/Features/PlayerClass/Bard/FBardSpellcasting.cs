using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardSpellcasting : AFeatureBard {
        public override string Name => "Spellcasting";
        public override string Text => FeatureBardText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardSpellcasting();
    }
}
