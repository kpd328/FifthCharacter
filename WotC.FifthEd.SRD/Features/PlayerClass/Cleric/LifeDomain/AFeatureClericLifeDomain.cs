using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Cleric.LifeDomain {
    public abstract class AFeatureClericLifeDomain : AFeatureCleric {
        public override string ID => string.Format("SRD.Feature.Class.Cleric.LifeDomain.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (College of Lore)", base.Source);
    }
}
