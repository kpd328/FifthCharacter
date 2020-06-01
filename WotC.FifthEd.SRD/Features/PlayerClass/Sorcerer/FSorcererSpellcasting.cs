using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer {
    public class FSorcererSpellcasting : AFeatureSorcerer {
        public override string Name => "Spellcasting";
        public override string Text => FeatureSorcererText.Spellcasting;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FSorcererSpellcasting();
    }
}
