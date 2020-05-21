using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;
using WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public abstract class FClericDivineDomain : AFeatureCleric {
        public override string Name => "Divine Domain";
        public override string Text => FeatureClericText.Divine_Domain;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public MultiValueDictionary<int, IFeature> DomainFeatures => new MultiValueDictionary<int, IFeature>() {
            { 1, new FClericLifeBonusProficiency() },
            { 1, new FClericLifeDiscipleOfLife() },
            { 2, new FClericLifeChannelDivinityPreserveLife() },
            { 6, new FClericLifeBlessedHealer() },
            { 8, new FClericLifeDivineStrike() },
            { 17, new FClericLifeSupremeHealing() }
        };
    }
}
