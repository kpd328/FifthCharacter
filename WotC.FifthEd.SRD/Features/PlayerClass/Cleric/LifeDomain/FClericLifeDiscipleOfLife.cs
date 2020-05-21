using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericLifeDiscipleOfLife : AFeatureClericLifeDomain {
        public override string Name => "Disciple of Life";
        public override string Text => FeatureClericLifeDomainText.Disciple_of_Life;
        public override bool IsActive => false;
        public override int ActiveUses => 0;

        public override IFeature GetInstance() => new FClericLifeDiscipleOfLife();
    }
}
