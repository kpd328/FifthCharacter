using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public class FRogueRoguishArchetypeThief : FRogueRoguishArchetype {
        public override string Name => "Rougish Archetype: Thief";
        public override string Text => FeatureRogueThiefText.Thief;
        public override MultiValueDictionary<int, IFeature> ArchetypeFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FRogueThiefFastHands() },
            { 3, new FRogueThiefSecondStoryWork() },
            { 9, new FRogueThiefSupremeSneak() },
            { 13, new FRogueThiefUseMagicDevice() },
            { 17, new FRogueThiefThiefsReflexes() }
        };

        public override IFeature GetInstance() {
            throw new System.NotImplementedException();
        }
    }
}
