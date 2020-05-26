using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Monk.WayOfTheOpenHand {
    public abstract class AFeatureMonkWayOfTheOpenHand : AFeatureMonk {
        public override string ID => string.Format("SRD.Feature.Class.Monk.WayOfTheOpenHand.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Way of the Open Hand)", base.Source);
    }
}
