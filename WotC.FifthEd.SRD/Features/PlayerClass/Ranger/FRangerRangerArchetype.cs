using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger {
    public abstract class FRangerRangerArchetype : AFeatureRanger {
        public override string Name => "Ranger Archetype";
        public override string Text => FeatureRangerText.Ranger_Archetype;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> ArchetypeFeatures { get; }
    }
}
