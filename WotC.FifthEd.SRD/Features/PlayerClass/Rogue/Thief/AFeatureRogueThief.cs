using System.Text.RegularExpressions;

namespace WotC.FifthEd.SRD.Features.PlayerClass.Rogue.Thief {
    public abstract class AFeatureRogueThief : AFeatureRogue {
        public override string ID => string.Format("SRD.Feature.Class.Rogue.Thief.{0}", Regex.Replace(Name, @"[^0-9a-zA-Z]+", ""));
        public override string Source => string.Format("{0} (Thief)", base.Source);
    }
}
