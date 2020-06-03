using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock {
    public class FWarlockMysticArcanum : AFeatureWarlock {
        //TODO: use this to trigger 6th, 7th, 8th and 9th level 'spell slots'
        public override string Name => "Mystic Arcanum";
        public override string Text => FeatureWarlockText.Mystic_Arcanum;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FWarlockMysticArcanum();
    }
}
