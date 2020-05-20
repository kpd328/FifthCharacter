using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard {
    public class FBardSongOfRest : AFeatureBard {
        public override string Name => "Song of Rest";
        public override string Text => FeatureBardText.Song_of_Rest;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FBardSongOfRest();
    }
}
