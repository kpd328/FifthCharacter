using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric {
    public abstract class FClericDivineDomain : AFeatureCleric {
        public override string Name => "Divine Domain";
        public override string Text => FeatureClericText.Divine_Domain;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> DomainFeatures { get; }
    }
}
