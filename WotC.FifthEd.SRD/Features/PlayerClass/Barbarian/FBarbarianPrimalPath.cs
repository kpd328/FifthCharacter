using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;
using WotC.FifthEd.SRD.Features.PlayerClass.Barbarian.PathOfTheBerserker;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Barbarian {
    public abstract class FBarbarianPrimalPath : AFeatureBarbarian {
        public override string Name => "Primal Path";
        public override string Text => FeatureBarbarianText.Primal_Path;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public MultiValueDictionary<int, IFeature> PathFeatures => new MultiValueDictionary<int, IFeature>() {
            { 3, new FBarbBerserkerFrenzy() },
            { 6, new FBarbBerserkerMindlessRage() },
            { 10, new FBarbBerserkerIntimidatingPresence() },
            { 14, new FBarbBerserkerRetaliation() }
        };
    }
}
