using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public class FRogueBlindsense : AFeatureRogue {
        public override string Name => "Blindsense";
        public override string Text => FeatureRogueText.Blindsense;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueBlindsense();
    }
}
