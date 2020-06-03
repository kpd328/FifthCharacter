using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Warlock.TheFiend {
    public abstract class AFeatureWarlockFiend : AFeatureWarlock {
        public override string ID => string.Format("SRD.Feature.Class.Warlock.Fiend.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (The Fiend)", base.Source);
    }
}
