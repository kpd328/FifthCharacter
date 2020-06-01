using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer {
    public abstract class FSorcererSorcerousOrigin : AFeatureSorcerer {
        public override string Name => "Sorcerous Origin";
        public override string Text => FeatureSorcererText.Sorcerous_Origin;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> OriginFeatures { get; }
    }
}
