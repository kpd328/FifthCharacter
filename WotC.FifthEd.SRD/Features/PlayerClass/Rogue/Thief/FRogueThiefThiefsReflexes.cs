using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueThiefThiefsReflexes : AFeatureRogueThief {
        public override string Name => "Thief's Reflexes";
        public override string Text => FeatureRogueThiefText.Theif_s_Reflexes;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FRogueThiefThiefsReflexes();
    }
}
