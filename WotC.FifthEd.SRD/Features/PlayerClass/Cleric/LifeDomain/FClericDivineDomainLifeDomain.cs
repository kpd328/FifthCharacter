using FifthCharacter.Plugin.Interface;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericDivineDomainLifeDomain : FClericDivineDomain {
        public override string Name => "Divine Domain: Life Domain";
        public override string Text => FeatureClericLifeDomainText.Life_Domain;

        public override IFeature GetInstance() => new FClericDivineDomainLifeDomain();
    }
}
