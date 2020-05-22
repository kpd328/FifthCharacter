using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Druid.CircleOfTheLand {
    public abstract class AFeatureDruidCircleOfTheLand : AFeatureDruid {
        public override string ID => string.Format("SRD.Feature.Class.Druid.CircleOfTheLand.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Circle of the Land)", base.Source);
    }
}
