using FifthCharacter.Plugin.Interface;
using Microsoft.Collections.Extensions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid {
    public abstract class FDruidDruidCircle : AFeatureDruid {
        public override string Name => "Druid Circle";
        public override string Text => FeatureDruidText.Druid_Circle;
        public override bool IsActive => false;
        public override int ActiveUses => 0;
        public abstract MultiValueDictionary<int, IFeature> CircleFeatures { get; }
    }
}
