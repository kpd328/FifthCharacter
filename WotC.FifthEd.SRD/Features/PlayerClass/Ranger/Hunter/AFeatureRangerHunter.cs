using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Ranger.Hunter {
    public abstract class AFeatureRangerHunter : AFeatureRanger {
        public override string ID => string.Format("SRD.Feature.Class.Ranger.Hunter.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Hunter)", base.Source);
    }
}
