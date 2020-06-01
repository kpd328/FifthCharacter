using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Sorcerer.DraconicBloodline {
    public abstract class AFeatureSorcererDraconicBloodline : AFeatureSorcerer {
        public override string ID => string.Format("SRD.Feature.Class.Sorcerer.DraconicBloodline.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Draconic Bloodline)", base.Source);
    }
}
