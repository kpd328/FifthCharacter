using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeChannelDivinityPreserveLife : AFeatureClericLifeDomain {
        public override string Name => "Channel Divinity: Preserve Life";
        public override string Text => FeatureClericLifeDomainText.Channel_Divinity__Preserve_Life;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericLifeChannelDivinityPreserveLife();
    }
}
