using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Fighter {
    public abstract class FFighterMartialArchetype : AFeatureFighter {
        public override string Name => "Martial Archetype";
        public override string Text => FeatureFighterText.Martial_Archetype;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> ArchetypeFeatures { get; }
    }
}
