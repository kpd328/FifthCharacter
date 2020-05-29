using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue {
    public abstract class FRogueRoguishArchetype : AFeatureRogue {
        public override string Name => "Roguish Archetype";
        public override string Text => FeatureRogueText.Roguish_Archetype;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> ArchetypeFeatures { get; }
    }
}
