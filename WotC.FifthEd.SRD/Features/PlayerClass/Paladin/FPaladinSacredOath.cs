using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Paladin {
    public abstract class FPaladinSacredOath : AFeaturePaladin {
        public override string Name => "Sacred Oath";
        public override string Text => FeaturePaladinText.Sacred_Oath;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> OathFeatures { get; }
    }
}
