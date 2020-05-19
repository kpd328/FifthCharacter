using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public class FBarbarianBrutalCritical : AFeatureBarbarian {
        public override string Name => "Brutal Critical";
        public override string Text => FeatureBarbarianText.Brutal_Critical;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBarbarianBrutalCritical();
    }
}
