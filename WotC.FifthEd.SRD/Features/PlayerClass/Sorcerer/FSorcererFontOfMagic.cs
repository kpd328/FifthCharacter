using FifthCharacter.Plugin.Interface;
using FifthCharacter.Plugin.StatsManager;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer {
    public class FSorcererFontOfMagic : AFeatureSorcerer {
        //TODO: facilitate trading between sorcery points and spell slots
        public override string Name => "Font of Magic";
        public override string Text => FeatureSorcererText.Font_of_Magic;
        public override bool IsActive => true;
        public override int ActiveUses => ClassManager.ClassLevel("Sorcerer");

        public override IFeature GetInstance() => new FSorcererFontOfMagic();
    }
}
