using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Bard.CollegeOfLore {
    public abstract class AFeatureBardCollegeOfLore : AFeatureBard {
        public override string Source => string.Format("{0} (College of Lore)", base.Source);
        public override string ID => string.Format("SRD.Feature.Class.Bard.CollegeOfLore.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
    }
}
