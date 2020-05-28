using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public class FClericDivineDomainLifeDomain : FClericDivineDomain {
        public override string Name => "Divine Domain: Life Domain";
        public override string Text => FeatureClericLifeDomainText.Life_Domain;
        public override MultiValueDictionary<int, IFeature> DomainFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FClericLifeBonusProficiency() },
            { 1, new FClericLifeDiscipleOfLife() },
            { 2, new FClericLifeChannelDivinityPreserveLife() },
            { 6, new FClericLifeBlessedHealer() },
            { 8, new FClericLifeDivineStrike() },
            { 17, new FClericLifeSupremeHealing() }
        };

        public override IFeature GetInstance() => new FClericDivineDomainLifeDomain();
    }
}
